namespace RemoteManager
{
    partial class Main
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
            this.btExecute = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.rbSwitchOff = new System.Windows.Forms.RadioButton();
            this.rbSleep = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.rbLock = new System.Windows.Forms.RadioButton();
            this.gbRadio = new System.Windows.Forms.GroupBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.lbState = new System.Windows.Forms.Label();
            this.dgvContact = new System.Windows.Forms.DataGridView();
            this.gbRadio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // btExecute
            // 
            this.btExecute.Location = new System.Drawing.Point(354, 22);
            this.btExecute.Name = "btExecute";
            this.btExecute.Size = new System.Drawing.Size(75, 23);
            this.btExecute.TabIndex = 0;
            this.btExecute.Text = "Execute";
            this.btExecute.UseVisualStyleBackColor = true;
            this.btExecute.Click += new System.EventHandler(this.btExecute_Click);
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 22);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(336, 20);
            this.tbURL.TabIndex = 1;
            this.tbURL.TextChanged += new System.EventHandler(this.tbURL_TextChanged);
            // 
            // rbSwitchOff
            // 
            this.rbSwitchOff.AutoSize = true;
            this.rbSwitchOff.Location = new System.Drawing.Point(6, 29);
            this.rbSwitchOff.Name = "rbSwitchOff";
            this.rbSwitchOff.Size = new System.Drawing.Size(74, 17);
            this.rbSwitchOff.TabIndex = 2;
            this.rbSwitchOff.TabStop = true;
            this.rbSwitchOff.Text = "Switch Off";
            this.rbSwitchOff.UseVisualStyleBackColor = true;
            this.rbSwitchOff.CheckedChanged += new System.EventHandler(this.rbSwitchOff_CheckedChanged);
            // 
            // rbSleep
            // 
            this.rbSleep.AutoSize = true;
            this.rbSleep.Location = new System.Drawing.Point(6, 64);
            this.rbSleep.Name = "rbSleep";
            this.rbSleep.Size = new System.Drawing.Size(52, 17);
            this.rbSleep.TabIndex = 3;
            this.rbSleep.TabStop = true;
            this.rbSleep.Text = "Sleep";
            this.rbSleep.UseVisualStyleBackColor = true;
            this.rbSleep.CheckedChanged += new System.EventHandler(this.rbSleep_CheckedChanged);
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(112, 29);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(60, 17);
            this.rbLogOff.TabIndex = 4;
            this.rbLogOff.TabStop = true;
            this.rbLogOff.Text = "Log Off";
            this.rbLogOff.UseVisualStyleBackColor = true;
            this.rbLogOff.CheckedChanged += new System.EventHandler(this.rbLogOff_CheckedChanged);
            // 
            // rbLock
            // 
            this.rbLock.AutoSize = true;
            this.rbLock.Location = new System.Drawing.Point(112, 64);
            this.rbLock.Name = "rbLock";
            this.rbLock.Size = new System.Drawing.Size(49, 17);
            this.rbLock.TabIndex = 5;
            this.rbLock.TabStop = true;
            this.rbLock.Text = "Lock";
            this.rbLock.UseVisualStyleBackColor = true;
            this.rbLock.CheckedChanged += new System.EventHandler(this.rbLock_CheckedChanged);
            // 
            // gbRadio
            // 
            this.gbRadio.Controls.Add(this.rbSwitchOff);
            this.gbRadio.Controls.Add(this.rbLock);
            this.gbRadio.Controls.Add(this.rbSleep);
            this.gbRadio.Controls.Add(this.rbLogOff);
            this.gbRadio.Location = new System.Drawing.Point(12, 58);
            this.gbRadio.Name = "gbRadio";
            this.gbRadio.Size = new System.Drawing.Size(174, 100);
            this.gbRadio.TabIndex = 6;
            this.gbRadio.TabStop = false;
            this.gbRadio.Text = "Action";
            // 
            // tbState
            // 
            this.tbState.Enabled = false;
            this.tbState.Location = new System.Drawing.Point(533, 22);
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(164, 20);
            this.tbState.TabIndex = 7;
            this.tbState.Text = "Disconnected";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(489, 27);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(38, 13);
            this.lbState.TabIndex = 8;
            this.lbState.Text = "State :";
            // 
            // dgvContact
            // 
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Location = new System.Drawing.Point(204, 58);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.Size = new System.Drawing.Size(584, 195);
            this.dgvContact.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvContact);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.tbState);
            this.Controls.Add(this.gbRadio);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btExecute);
            this.Name = "Main";
            this.Text = "Form1";
            this.gbRadio.ResumeLayout(false);
            this.gbRadio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExecute;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.RadioButton rbSwitchOff;
        private System.Windows.Forms.RadioButton rbSleep;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.RadioButton rbLock;
        private System.Windows.Forms.GroupBox gbRadio;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.DataGridView dgvContact;
    }
}

