using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class frmMain : Sample
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            guna2ControlBox1.PerformClick();
        }

        /*private void AddControls(Form F)
        {
            ControlsPanel.Controls.Clear();
            F.TopLevel = false;
            ControlsPanel.Controls.Add(F);
            F.BringToFront();
            F.Dock = DockStyle.Fill;
            F.Show();



        }*/

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navigtionMenu1_OnItemSelected(object sender, string path, EventArgs e)
        {
            switch (path)
            {
                case "Dashboard":
                    break;
                /*case "Settings.Users":
                    AddControls(new frmMain());
                    break;*/
            }
        }
    }
}
