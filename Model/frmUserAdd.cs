using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Model
{
    public partial class frmUserAdd : SampleAdd
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        public int id = 0;
        private void frmUserAdd_Load(object sender, EventArgs e)
        {
            if (id >0)
            {
                DataTable dt = MainClass.GetData("Select * from tblUser where userID= " + id + "");
                foreach (DataRow row in dt.Rows)
                {
                    txtName.Text = row["uName"].ToString();
                    txtUser.Text = row["uUsername"].ToString();
                    txtPass.Text = row["uPass"].ToString();
                    txtPhone.Text = row["uPhone"].ToString();
                    CbStatus.Text = row["uStatus"].ToString();                   
                }
            }
        }
        public override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            string qry = "";
            if (id==0) //insert
            {
                qry = "Insert into tblUser Values(@name,@user,@pass,@phone,@status)";
            }
            else
            {
                qry = "Update tblUser set uName =@name , uUsername =@user, uPass = u@pass ,uPhone = @phone, uStatus = @status where userID = @id";
            }
            Hashtable ht = new Hashtable();
            ht.Add("@id",id);
            ht.Add("@name", txtName.Text);   
            ht.Add("@user",txtUser.Text);
            ht.Add("@pass",txtPass.Text);
            ht.Add("@phone",txtPhone.Text);
            ht.Add("@status",CbStatus.Text);

            int r= MainClass.data_insert_update_delete(qry,ht);
            if (r > 0)
            {
                guna2MessageDialog1.Show("Saved Successfully");
                MainClass.Enable_reset(this);
                id = 0;
            }
            

        }

        public override void btnDel_Click(object sender, EventArgs e)
        {
            if (id>0)
            {
                string qry = "Delete from tblUser where userID=" + id + "";
                Hashtable ht = new Hashtable();
                MainClass.data_insert_update_delete(qry, ht);
                guna2MessageDialog1.Show("Deleted Successfull");
                MainClass.Enable_reset(this);
                id = 0;
            }
        }
        
    }
}
