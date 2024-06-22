using SchoolManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Views
{
    public partial class frmUserView : SampleView
    {
        public frmUserView()
        {
            InitializeComponent();
        }

        private void frmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            frmUserAdd frm = new frmUserAdd();
            frm.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            string qry = "Select * from tblUser where uName like '%"+txtSearch.Text+"%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvUser);
            lb.Items.Add(dgvPass);
            lb.Items.Add(dgvPhone);
            lb.Items.Add(dgvStatus);
            MainClass.loadData(qry, guna2DataGridView1, lb);
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            frmUserAdd frm = new frmUserAdd();
            frm.id = id;
            frm.ShowDialog();
            LoadData();
        }
    }
}
