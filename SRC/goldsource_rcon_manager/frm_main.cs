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
            RCON cs = new RCON();
            this.txtResponse.Text = ""; 
            try {
                if (txtPassword.Text == ""
                    || txtServerIP.Text == ""
                    || txtServerPort.Text == "") {
                        MessageBox.Show("Please fill out the loginform completely!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                       this.txtResponse.Text = cs.sendRCON(
                    this.txtServerIP.Text, int.Parse(this.txtServerPort.Text),
                    this.txtPassword.Text, this.txtCommand.Text).Replace("\n", "\r\n");
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
