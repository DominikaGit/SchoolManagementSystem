using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SchoolManagementSystem
{
    public class MainClass
    {
        public static readonly string cons = "Data Source=Dominika;Initial Catalog=School;User ID=sa;Password=123;"; //connection string
        public static SqlConnection con = new SqlConnection(cons);

        public static bool isValidUser(string user, string pass) //for user validation
        {
            bool isValid = false;

            string qry = "Select * from tblUser where uUsername = @user and uPass = @pass";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
            }
            return isValid;
        }

        public static void CBFill(string qry, ComboBox cb) //for combobox fill
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = "name";
                cb.ValueMember = "id";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public static int data_insert_update_delete(string qry, Hashtable ht) //for insert, update, delete
        {
            int res = 0;
            try
            {
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                MainClass.con.Open();
                res = cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.Message);
            }
            return res;
        }

        public static void loadData(string qry, DataGridView gv, ListBox lb) //for loading data from db to gridview
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.ToString());
            }
        }

        public static DataTable GetData(string qry) //for update
        { 
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(qry, MainClass.con);
                cmd.CommandType = System.Data.CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MessageBox.Show(ex.ToString());
            }
            return dt;
        }

        public static void SrNo(Guna.UI2.WinForms.Guna2DataGridView gv) //for gridview serial number
        {
            try
            {
                int count = 0;
                foreach (DataGridViewRow row in gv.Rows)
                {
                    count++;
                    row.Cells[0].Value = count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }

        private static Color vColor = Color.FromArgb(245, 29, 70);

        //Validation
        public static bool Validation(Form F) //for validation see form validation video
        {
            bool isValid = true;
            int count = 0;
            int x;
            int y;

            //Remove old labels
            var dynamicLabels = F.Controls.OfType<Label>().Where(c => c.Tag != null && c.Tag.ToString() == "remove").ToList();
            foreach (var lbl in dynamicLabels)
            {
                F.Controls.Remove(lbl);
            }

            foreach (Control c in F.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    // Do nothing for buttons
                }
                else
                {
                    if (c.Tag == null || c.Tag.ToString() == string.Empty)
                    {
                        // Do nothing if no tag
                    }
                    else
                    {
                        Label lbl = new Label();
                        lbl.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                        lbl.AutoSize = true;

                        if (c is Guna.UI2.WinForms.Guna2TextBox) //TextBox
                        {
                            Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse((c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString()));
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            if (t.Text == "")
                            {
                                string cname = "vlbl" + c.Name;
                                lbl.Name = cname;
                                lbl.Tag = "remove";
                                lbl.Text = "Required";
                                lbl.ForeColor = vColor;
                                F.Controls.Add(lbl);
                                lbl.Location = new System.Drawing.Point(x, y);
                                count++;
                            }
                        }
                        if (c is Guna.UI2.WinForms.Guna2TextBox) //Email
                        {
                            Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            if (t.Tag.ToString() == "e" && t.Text != "")
                            {
                                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+$");
                                Match match = regex.Match(t.Text);
                                if (match.Success) { }
                                else
                                {
                                    string cname = "elbl" + c.Name;
                                    lbl.Name = cname;
                                    lbl.Tag = "remove";
                                    lbl.Text = "Invalid Email";
                                    lbl.ForeColor = vColor;
                                    F.Controls.Add(lbl);
                                    lbl.Location = new System.Drawing.Point(x, y);
                                    count++;
                                }
                            }
                        }
                        if (c is Guna.UI2.WinForms.Guna2TextBox) //Number
                        {
                            Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            if (t.Tag.ToString() == "n" && t.Text != "")
                            {
                                Regex regex = new Regex(@"^-?[0-9][0-9,\.]*$");
                                Match match = regex.Match(t.Text);
                                if (match.Success) { }
                                else
                                {
                                    string cname = "nlbl" + c.Name;
                                    lbl.Name = cname;
                                    lbl.Tag = "remove";
                                    lbl.Text = "Invalid Number";
                                    lbl.ForeColor = vColor;
                                    F.Controls.Add(lbl);
                                    lbl.Location = new System.Drawing.Point(x, y);
                                    count++;
                                }
                            }
                        }
                        if (c is Guna.UI2.WinForms.Guna2TextBox) //Date
                        {
                            Guna.UI2.WinForms.Guna2TextBox t = (Guna.UI2.WinForms.Guna2TextBox)c;
                            if (t.AutoRoundedCorners == true)
                            {
                                x = int.Parse(c.Location.X.ToString()) + 10;
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            else
                            {
                                x = int.Parse(c.Location.X.ToString());
                                y = int.Parse(c.Location.Y.ToString()) + 5 + int.Parse(c.Height.ToString());
                            }
                            if (t.Tag.ToString() == "d" && t.Text != "")
                            {
                                DateTime dt = new DateTime(1, 1, 1);
                                bool isDate = DateTime.TryParse(t.Text, out dt);
                                if (isDate) { }
                                else
                                {
                                    string cname = "dlbl" + c.Name;
                                    lbl.Name = cname;
                                    lbl.Tag = "remove";
                                    lbl.Text = "Invalid Date";
                                    lbl.ForeColor = vColor;
                                    F.Controls.Add(lbl);
                                    lbl.Location = new System.Drawing.Point(x, y);
                                    count++;
                                }
                            }
                        }
                    }
                }
            }
            if (count > 0)
            {
                isValid = false;
            }
            return isValid;
        }

        // Adding the Enable_reset method
        public static void Enable_reset(Form F)
        {
            foreach (Control c in F.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button btn)
                {
                    btn.Enabled = true;
                }
                if (c is Guna.UI2.WinForms.Guna2TextBox txt)
                {
                    txt.Text = string.Empty;
                }
                // Add similar reset logic for other controls if needed
            }
        }
    }
}
