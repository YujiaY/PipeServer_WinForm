namespace PipeServer_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.lb1 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(13, 197);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(127, 13);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Enter your message here:";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(16, 218);
            this.tbInput.Multiline = true;
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(363, 102);
            this.tbInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 339);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(363, 33);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Location = new System.Drawing.Point(16, 13);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(234, 40);
            this.lbInfo.TabIndex = 3;
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(19, 129);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(360, 65);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Click to connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbState
            // 
            this.lbState.Location = new System.Drawing.Point(16, 53);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(234, 73);
            this.lbState.TabIndex = 5;
            this.lbState.Click += new System.EventHandler(this.lbState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 401);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "PipeServer_WinForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbState;
    }
}

