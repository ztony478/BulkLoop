using System;
using System.Threading;
using System.Windows.Forms;
using CyUSB;

namespace BulkLoop
{
    public partial class Form1 : Form
    {
        CyUSBDevice         loopDevice  = null;
        USBDeviceList       usbDevices  = null;
        CyBulkEndPoint      inEndpoint  = null;
        CyBulkEndPoint      outEndpoint = null;

        Thread  tXfers;

        bool SendData = false;

        const int XFERSIZE  = 5;
        byte[]  outData     = new byte[XFERSIZE];
        byte[]  inData      = new byte[XFERSIZE];

        // These 2 needed for TransfersThread to update the UI
        delegate void UpdateUICallback();
        UpdateUICallback updateUI;
     
        public Form1()
        {
            InitializeComponent();

            // Setup the callback routine for updating the UI
            updateUI    = new UpdateUICallback(StatusUpdate);

            // Create a list of CYUSB devices
            usbDevices  = new USBDeviceList(CyConst.DEVICES_CYUSB);

            //Adding event handlers for device attachment and device removal
            usbDevices.DeviceAttached += new EventHandler(usbDevices_DeviceAttached);
            usbDevices.DeviceRemoved += new EventHandler(usbDevices_DeviceRemoved);

            //The below function sets the device with particular VID and PId and searches for the device with the same VID and PID.
            setDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outData[0] = (byte)(0x55);
            outData[4] = (byte)(0xAA);

            //creates new thread
            tXfers = new Thread(new ThreadStart(TransfersThread));
            tXfers.IsBackground = true;
            tXfers.Priority = ThreadPriority.Highest;
            //Starts the new thread
            tXfers.Start();
        }

        void StatusUpdate()
        {
            BytesInCmd.Text = inData[1].ToString();
            BytesInDataMSB.Text = inData[2].ToString();
            BytesInDataLSB.Text = inData[3].ToString();

            BytesInCmd.Refresh();
        }
        
        /* Summary
            This is the event handler for Device removal event.
        */
        void usbDevices_DeviceRemoved(object sender, EventArgs e)
        {
            setDevice();
        }


        /* Summary
            This is the event handler for Device Attachment event.
        */
        void usbDevices_DeviceAttached(object sender, EventArgs e)
        {
            setDevice();
        }


        /* Summary
            The function sets the device, as the one having VID=04b4 and PID=1004
            This will detect only the devices with the above VID,PID combinations
        */
        public void setDevice()
        {
            try
            {
                loopDevice = usbDevices[0x04b4, 0x8613] as CyUSBDevice;

                StartBtn.Enabled = (loopDevice != null);

                if (loopDevice != null)
                    Text = loopDevice.FriendlyName;
                else
                    Text = "BVCOMVC - no device";

                outEndpoint = loopDevice.EndPointOf(0x02) as CyBulkEndPoint;
                inEndpoint = loopDevice.EndPointOf(0x86) as CyBulkEndPoint;

                outEndpoint.TimeOut = 1000;
                inEndpoint.TimeOut = 1000;
            }
            catch
            {
                Text = "BVCOMVC - no device";
            }
        }


        /* Summary
            closing the open form
        */
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If close was selected while running the loopback, shut it down.
            if (tXfers.IsAlive)
            {
                tXfers.Abort();
                tXfers.Join();
                tXfers = null;
            }

            if (usbDevices != null) 
                usbDevices.Dispose();
        }

        /* Summary
            Executes on Start button click
        */
        private void StartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                lock (this)
                {
                    SendData = true;
                    outData[1] = Convert.ToByte(CmdLabel.Text);
                    outData[2] = Convert.ToByte(DataMSBLabel.Text);
                    outData[3] = Convert.ToByte(DataLSBLabel.Text);
                }
            }
            catch
            {}
        }
        
        /* Summary
            This thread is initiated on start button click.Run the thread and executes the transfer and invokes the StatusUpdate to update the UI 
        */
        public void TransfersThread()
        {   
            int xferLen = XFERSIZE;
            
            byte[] tmpOutData = new byte[5];
            byte[] tmpInData = new byte[5];

            bool bResult = true;

            // Loop stops if either an IN or OUT transfer fails
            while (bResult)
            {
                try
                {
                    if (SendData)
                    {
                        lock (this)
                        {
                            for (int i = 0; i < outData.Length; i++)
                            {
                                tmpOutData[i] = outData[i];
                            }
                        }

                        //calls the XferData function for bulk transfer(OUT/IN) in the cyusb.dll
                        bResult = outEndpoint.XferData(ref tmpOutData, ref xferLen);

                        if (bResult)
                        {//calls the XferData function for bulk transfer(OUT/IN) in the cyusb.dll
                            bResult = inEndpoint.XferData(ref tmpInData, ref xferLen);
                        }

                        lock (this)
                        {
                            for (int i = 0; i < inData.Length; i++)
                            {
                                inData[i] = tmpInData[i];
                            }
                        }

                        // Call StatusUpdate() in the main thread
                        this.Invoke(updateUI);

                        lock (this)
                        {
                            SendData = false;
                        }
                    }
                }
                catch
                {}
            }

            MessageBox.Show("Time Out");
        }
    }
}