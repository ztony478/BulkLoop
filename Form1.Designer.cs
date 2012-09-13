namespace BulkLoop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        
        /* Summary
         The function is used to dispose or clean up all the resources allocated, after the use.
         <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        */
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BytesInCmd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BytesInDataLSB = new System.Windows.Forms.Label();
            this.BytesInDataMSB = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DataLSBLabel = new System.Windows.Forms.TextBox();
            this.DataMSBLabel = new System.Windows.Forms.TextBox();
            this.CmdLabel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.BackColor = System.Drawing.Color.Aquamarine;
            this.StartBtn.Location = new System.Drawing.Point(372, 80);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 21);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "Transfer";
            this.StartBtn.UseVisualStyleBackColor = false;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bytes transferred OUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bytes transferred IN";
            // 
            // BytesInCmd
            // 
            this.BytesInCmd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BytesInCmd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BytesInCmd.Location = new System.Drawing.Point(156, 13);
            this.BytesInCmd.Name = "BytesInCmd";
            this.BytesInCmd.Size = new System.Drawing.Size(39, 18);
            this.BytesInCmd.TabIndex = 6;
            this.BytesInCmd.Text = "0";
            this.BytesInCmd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.StartBtn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 117);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.BytesInCmd);
            this.groupBox3.Controls.Add(this.BytesInDataLSB);
            this.groupBox3.Controls.Add(this.BytesInDataMSB);
            this.groupBox3.Location = new System.Drawing.Point(8, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 46);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // BytesInDataLSB
            // 
            this.BytesInDataLSB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BytesInDataLSB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BytesInDataLSB.Location = new System.Drawing.Point(281, 13);
            this.BytesInDataLSB.Name = "BytesInDataLSB";
            this.BytesInDataLSB.Size = new System.Drawing.Size(39, 18);
            this.BytesInDataLSB.TabIndex = 6;
            this.BytesInDataLSB.Text = "0";
            this.BytesInDataLSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BytesInDataMSB
            // 
            this.BytesInDataMSB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BytesInDataMSB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BytesInDataMSB.Location = new System.Drawing.Point(217, 13);
            this.BytesInDataMSB.Name = "BytesInDataMSB";
            this.BytesInDataMSB.Size = new System.Drawing.Size(39, 18);
            this.BytesInDataMSB.TabIndex = 6;
            this.BytesInDataMSB.Text = "0";
            this.BytesInDataMSB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DataLSBLabel);
            this.groupBox2.Controls.Add(this.DataMSBLabel);
            this.groupBox2.Controls.Add(this.CmdLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 47);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // DataLSBLabel
            // 
            this.DataLSBLabel.Location = new System.Drawing.Point(281, 14);
            this.DataLSBLabel.Name = "DataLSBLabel";
            this.DataLSBLabel.Size = new System.Drawing.Size(39, 21);
            this.DataLSBLabel.TabIndex = 9;
            // 
            // DataMSBLabel
            // 
            this.DataMSBLabel.Location = new System.Drawing.Point(217, 14);
            this.DataMSBLabel.Name = "DataMSBLabel";
            this.DataMSBLabel.Size = new System.Drawing.Size(39, 21);
            this.DataMSBLabel.TabIndex = 9;
            // 
            // CmdLabel
            // 
            this.CmdLabel.Location = new System.Drawing.Point(156, 14);
            this.CmdLabel.Name = "CmdLabel";
            this.CmdLabel.Size = new System.Drawing.Size(39, 21);
            this.CmdLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 117);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BVCOMVC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BytesInCmd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label BytesInDataLSB;
        private System.Windows.Forms.Label BytesInDataMSB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox CmdLabel;
        private System.Windows.Forms.TextBox DataLSBLabel;
        private System.Windows.Forms.TextBox DataMSBLabel;
    }
}

