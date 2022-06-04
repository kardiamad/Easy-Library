using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace N01413931_Project
{
    public partial class frmAccount : Form
    {
        SqlConnection conn;
        private frmMain fmain;
        public frmAccount(frmMain main)
        {
            InitializeComponent();
            this.fmain = main;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Account WHERE Login='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";

            using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
            using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    User user = new User();
                    user.setName(txtUserName.Text);

                    Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    configuration.AppSettings.Settings["login"].Value = "true";
                    configuration.Save(ConfigurationSaveMode.Full, true);
                    ConfigurationManager.RefreshSection("appSettings");


                    fmain.ChangeLabel(txtUserName.Text);
                    this.Close();

                   
                }
                else
                {
                    MessageBox.Show("Please Check your UserName and Password");
                }
            }
        }

        private void btnExitReg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoginNew_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Account VALUES(@UserNameNew, @PasswordNew)";

            using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
            using (SqlCommand sc = new SqlCommand(query, conn))
            {
                conn.Open();
                
                sc.Parameters.AddWithValue("@UserNameNew", txtUserNameNew.Text);
                sc.Parameters.AddWithValue("@PasswordNew", txtPasswordNew.Text);

                sc.ExecuteScalar();

                MessageBox.Show("A new Account is added");
            }
        }
    }
}
