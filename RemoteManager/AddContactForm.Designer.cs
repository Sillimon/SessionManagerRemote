namespace RemoteManager
{
    partial class AddContactForm
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
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.MaskedTextBox();
            this.LbIP = new System.Windows.Forms.Label();
            this.lbHostName = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.MaskedTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(41, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name :";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(81, 10);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(253, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(81, 55);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(253, 20);
            this.tbIP.TabIndex = 2;
            // 
            // LbIP
            // 
            this.LbIP.AutoSize = true;
            this.LbIP.Location = new System.Drawing.Point(12, 58);
            this.LbIP.Name = "LbIP";
            this.LbIP.Size = new System.Drawing.Size(35, 13);
            this.LbIP.TabIndex = 3;
            this.LbIP.Text = "IPv4 :";
            // 
            // lbHostName
            // 
            this.lbHostName.AutoSize = true;
            this.lbHostName.Location = new System.Drawing.Point(12, 103);
            this.lbHostName.Name = "lbHostName";
            this.lbHostName.Size = new System.Drawing.Size(63, 13);
            this.lbHostName.TabIndex = 4;
            this.lbHostName.Text = "HostName :";
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(81, 100);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(253, 20);
            this.tbHostName.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(117, 140);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(128, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "ADD CONTACT";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 175);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbHostName);
            this.Controls.Add(this.lbHostName);
            this.Controls.Add(this.LbIP);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.MaskedTextBox tbIP;
        private System.Windows.Forms.Label LbIP;
        private System.Windows.Forms.Label lbHostName;
        private System.Windows.Forms.MaskedTextBox tbHostName;
        private System.Windows.Forms.Button btAdd;
    }
}