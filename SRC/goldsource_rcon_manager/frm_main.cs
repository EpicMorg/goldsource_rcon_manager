using System;
using System.Windows.Forms;
using gSDK_vgui;
 

namespace goldsource_rcon_manager {
    public partial class frm_main : FrmTemplate {
        public frm_main() {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e) {

        }

        private void btnSend_Click(object sender, EventArgs e) {
            var cs = new Rcon();
            var pass = txtPassword.Text;
            var iptext = txtServerIP.Text;
            var portt = txtServerPort.Text;
            this.txtResponse.Text = ""; 

            try {
                if (pass == ""
                    || iptext == ""
                    || portt == "") {
                        MessageBox.Show("Please fill out the loginform completely!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                       this.txtResponse.Text = cs.SendRcon(iptext, int.Parse(portt), pass, this.txtCommand.Text).Replace("\n", "\r\n");
                }
              
            }
            catch (Exception ex) {
                    MessageBox.Show("You are doing thomething wrong..." +Environment.NewLine+ ex.ToString() , "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     
                return;
            }

        }

        private void btnAbout_Click(object sender, EventArgs e) {
            MessageBox.Show("Created by STAM, EpicMorg, 2014", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
        }
    }
}
