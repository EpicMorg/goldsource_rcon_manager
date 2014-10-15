namespace goldsource_rcon_manager {
    partial class frm_main {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblSeverPort = new System.Windows.Forms.Label();
            this.lblRCONPassword = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.ComboBox();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_btn_min
            // 
            this.pic_btn_min.Location = new System.Drawing.Point(388, 12);
            // 
            // pic_btn_max
            // 
            this.pic_btn_max.Location = new System.Drawing.Point(412, 12);
            // 
            // pic_btn_exit
            // 
            this.pic_btn_exit.Location = new System.Drawing.Point(436, 12);
            // 
            // pic_logo
            // 
            this.pic_logo.Image = global::goldsource_rcon_manager.Properties.Resources.game_001;
            // 
            // lbl_title
            // 
            this.lbl_title.Location = new System.Drawing.Point(58, 13);
            this.lbl_title.Size = new System.Drawing.Size(135, 13);
            this.lbl_title.Text = "Goldsource Rcon Manager";
            // 
            // lblServerIP
            // 
            this.lblServerIP.AutoSize = true;
            this.lblServerIP.Location = new System.Drawing.Point(12, 42);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(54, 13);
            this.lblServerIP.TabIndex = 8;
            this.lblServerIP.Text = "Server IP:";
            // 
            // lblSeverPort
            // 
            this.lblSeverPort.AutoSize = true;
            this.lblSeverPort.Location = new System.Drawing.Point(187, 42);
            this.lblSeverPort.Name = "lblSeverPort";
            this.lblSeverPort.Size = new System.Drawing.Size(63, 13);
            this.lblSeverPort.TabIndex = 8;
            this.lblSeverPort.Text = "Server Port:";
            // 
            // lblRCONPassword
            // 
            this.lblRCONPassword.AutoSize = true;
            this.lblRCONPassword.Location = new System.Drawing.Point(295, 42);
            this.lblRCONPassword.Name = "lblRCONPassword";
            this.lblRCONPassword.Size = new System.Drawing.Size(90, 13);
            this.lblRCONPassword.TabIndex = 8;
            this.lblRCONPassword.Text = "RCON Password:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(379, 322);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txtCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.txtCommand.FormattingEnabled = true;
            this.txtCommand.Items.AddRange(new object[] {
            "changelevel",
            "maps * ",
            "kick",
            "users ",
            "say",
            "cm_say @@r",
            "quit"});
            this.txtCommand.Location = new System.Drawing.Point(12, 324);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(361, 21);
            this.txtCommand.TabIndex = 3;
            // 
            // txtServerIP
            // 
            this.txtServerIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txtServerIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.txtServerIP.Location = new System.Drawing.Point(12, 58);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(172, 20);
            this.txtServerIP.TabIndex = 0;
            this.txtServerIP.Text = "game.stargate-vk.tk";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.txtPassword.Location = new System.Drawing.Point(298, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(156, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "O5cMXDtMz79KQ1.-BB\"P6W2eAzSGWp";
            // 
            // txtServerPort
            // 
            this.txtServerPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txtServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.txtServerPort.Location = new System.Drawing.Point(190, 58);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(102, 20);
            this.txtServerPort.TabIndex = 1;
            this.txtServerPort.Text = "27018";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(34, 11);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(18, 17);
            this.btnAbout.TabIndex = 100;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(70)))), ((int)(((byte)(55)))));
            this.txtResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(145)))), ((int)(((byte)(128)))));
            this.txtResponse.Location = new System.Drawing.Point(12, 84);
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.Size = new System.Drawing.Size(442, 232);
            this.txtResponse.TabIndex = 101;
            this.txtResponse.Text = "";
            // 
            // frm_main
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 357);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblRCONPassword);
            this.Controls.Add(this.lblSeverPort);
            this.Controls.Add(this.lblServerIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goldsource Rcon Manager";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.Controls.SetChildIndex(this.lblServerIP, 0);
            this.Controls.SetChildIndex(this.lblSeverPort, 0);
            this.Controls.SetChildIndex(this.lblRCONPassword, 0);
            this.Controls.SetChildIndex(this.btnSend, 0);
            this.Controls.SetChildIndex(this.txtCommand, 0);
            this.Controls.SetChildIndex(this.txtServerIP, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.txtServerPort, 0);
            this.Controls.SetChildIndex(this.lbl_title, 0);
            this.Controls.SetChildIndex(this.pic_logo, 0);
            this.Controls.SetChildIndex(this.pic_btn_min, 0);
            this.Controls.SetChildIndex(this.pic_btn_exit, 0);
            this.Controls.SetChildIndex(this.pic_btn_max, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.txtResponse, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblSeverPort;
        private System.Windows.Forms.Label lblRCONPassword;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox txtCommand;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtServerPort;
     
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.RichTextBox txtResponse;
    }
}

