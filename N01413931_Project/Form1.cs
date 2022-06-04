using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace N01413931_Project
{
    public partial class frmMain : Form
    {
        SqlConnection conn;
        

        public frmMain()
        {
            InitializeComponent();
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["login"].Value = "false";
            configuration.Save(ConfigurationSaveMode.Full, true);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void ChangeLabel(string str)
        {
            
            lblAccount.Text += str;
            btnSign.Text = "Sign Out";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string value = ConfigurationManager.AppSettings["login"];
            if (value.Equals("false"))
            {
                frmAccount account = new frmAccount(this);
                account.Show();
            }
            else
            {
                string message = "Do you want to log out?";
                string title = "Log Out";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    lblAccount.Text = "User name: ";
                    btnSign.Text = "Sign In";
                    Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    configuration.AppSettings.Settings["login"].Value = "false";
                    configuration.Save(ConfigurationSaveMode.Full, true);
                    ConfigurationManager.RefreshSection("appSettings");
                }
            }
            
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void bookTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bookTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLibraryDataSet);

        }

        private void bookTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bookTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseLibraryDataSet);

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseLibraryDataSet.BookTable' table. You can move, or remove it, as needed.
            this.bookTableTableAdapter.Fill(this.databaseLibraryDataSet.BookTable);
            if (cmbxType.Items.Count < 2) { 
                FillCmbx("TypeBook");
                cmbxType.SelectedItem = cmbxType.Items[0];
            }
            if (cmbxGenre.Items.Count < 2) { 
                FillCmbx("GenreBook");
                cmbxGenre.SelectedItem = cmbxGenre.Items[0];
            }
            if (cmbxStatus.Items.Count < 2) { 
                FillCmbx("StatusBook");
                cmbxStatus.SelectedItem = cmbxStatus.Items[0];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string value = ConfigurationManager.AppSettings["login"];
            if (value.Equals("false"))
            {
                MessageBox.Show("Please, first you have to log in", "Account");
            }
            else if (txtISBN.Text.Equals("") || txtTitle.Text.Equals("") || cmbxType.Text.Equals("") || cmbxStatus.Text.Equals(""))
            {
                MessageBox.Show("Please, fill the necessary fields");
            }
            else if (txtISBN.Text.Length > 18) { MessageBox.Show("Error, First name cannot be greater than 18 characters", "Account"); }
            else if (!isInt(txtISBN.Text)) { MessageBox.Show("Error, ISBN must be a Number", "Account"); }
            else if (txtTitle.Text.Length > 80) { MessageBox.Show("Error, Title cannot be greater than 80 characters", "Account"); }
            else if (txtPublisher.Text.Length > 80) { MessageBox.Show("Error, Publisher cannot be greater than 80 characters", "Account"); }
            else
            {
                try
                {
                    string query = "INSERT INTO BookTable VALUES(@ISBN, @Title, @Type, @Status, @Genre, @Publisher, @PublDate, @Desc)";

                    using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                    using (SqlCommand sc = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        sc.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                        sc.Parameters.AddWithValue("@Title", txtTitle.Text);
                        sc.Parameters.AddWithValue("@Type", cmbxType.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Status", cmbxStatus.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Genre", cmbxGenre.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Publisher", txtPublisher.Text);
                        sc.Parameters.AddWithValue("@PublDate", dtpAdd.Value);
                        sc.Parameters.AddWithValue("@Desc", rtxtbxDesc.Text);

                        sc.ExecuteScalar();

                        MessageBox.Show("A new Book is added", "Database");
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
                
                txtISBN.Text = "";
                txtTitle.Text = "";
                txtPublisher.Text = "";
                rtxtbxDesc.Text = "";
            }
        }

        private static bool isInt(string str)
        {
            if (str == null || str.Length == 0)
            {
                return false;
            }
            try
            {
                Int32.Parse(str);
                return true;
            }
            catch (FormatException e)
            {
                return false;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string value = ConfigurationManager.AppSettings["login"];
            if (value.Equals("false"))
            {
                MessageBox.Show("Please, first you have to log in", "Account");
            }
            else if (txtISBNFind.Text.Equals(""))
            {
                MessageBox.Show("Please, fill the necessary fields");
            }
            else if (txtISBNFind.Text.Length > 18) { MessageBox.Show("Error, First name cannot be greater than 18 characters", "Account"); }
            else if (!isInt(txtISBNFind.Text)) { MessageBox.Show("Error, ISBN must be a Number", "Account"); }
            else
            {
                try
                {
                    string query = "SELECT * FROM BookTable WHERE ISBN='" + txtISBNFind.Text + "'";

                    using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Book book = new Book(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(),
                                dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString(), dt.Rows[0][7].ToString());

                            txtTitleFind.Text = book.getTitle();
                            cmbxTypeChange.Text = book.getType();
                            cmbxStatusChange.Text = book.getStatus();
                            cmbxGenreChange.Text = book.getGenre();
                            txtPublisherFind.Text = book.getPublisher();
                            dtpChange.Text = book.getPubldate();
                            rtxtbxDescFind.Text = book.getDesc();

                        }
                        else
                        {
                            MessageBox.Show("Please Enter the correct ISBN", "Database");
                        }
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
        }

        private void mnuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string value = ConfigurationManager.AppSettings["login"];
            if (value.Equals("false"))
            {
                MessageBox.Show("Please, first you have to log in", "Account");
            }
            else if (txtISBNFind.Text.Equals(""))
            {
                MessageBox.Show("Please, fill the necessary fields");
            }
            else
            {
                string message = "Do you want to remove the record?";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, "Delete", buttons);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM BookTable WHERE ISBN='" + txtISBNFind.Text + "'";

                    using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                    using (SqlCommand sc = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        sc.ExecuteScalar();

                        MessageBox.Show("Record with ISBN: " + txtISBNFind.Text + " was removed", "Database");
                    }
                }
            }
            
        }

        private void tbBooks_Selected(object sender, TabControlEventArgs e)
        {
            if (tbBooks.SelectedTab.Text.Equals("Display"))
            {
                string query = "SELECT * FROM BookTable";

                using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    bookTableDataGridView.DataSource = dt;
                }
            }
            else if (tbBooks.SelectedTab.Text.Equals("Find/Change/Remove"))
            {
                if (cmbxTypeChange.Items.Count < 2) { 
                    FillCmbx("TypeBook");
                    cmbxTypeChange.SelectedItem = cmbxType.Items[0];
                }
                if (cmbxGenreChange.Items.Count < 2) { 
                    FillCmbx("GenreBook");
                    cmbxGenre.SelectedItem = cmbxGenre.Items[0];
                }
                if (cmbxStatusChange.Items.Count < 2) { 
                    FillCmbx("StatusBook");
                    cmbxStatus.SelectedItem = cmbxStatus.Items[0];
                }
            }
        }

        private void FillCmbx(string table)
        {
            try
            {
                string query = "SELECT * FROM " + table;

                using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                using (SqlDataAdapter sda = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (table.Equals("TypeBook"))
                            {
                                cmbxType.Items.Add(dt.Rows[i][0].ToString());
                                cmbxTypeChange.Items.Add(dt.Rows[i][0].ToString());
                            }
                            if (table.Equals("GenreBook"))
                            {
                                cmbxGenre.Items.Add(dt.Rows[i][0].ToString());
                                cmbxGenreChange.Items.Add(dt.Rows[i][0].ToString());
                            }
                            if (table.Equals("StatusBook"))
                            {
                                cmbxStatus.Items.Add(dt.Rows[i][0].ToString());
                                cmbxStatusChange.Items.Add(dt.Rows[i][0].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            string value = ConfigurationManager.AppSettings["login"];
            if (value.Equals("false"))
            {
                MessageBox.Show("Please, first you have to log in", "Account");
            }
            else if (txtISBNFind.Text.Equals("") && txtTitleFind.Text.Equals("") && cmbxTypeChange.Text.Equals("") && cmbxStatusChange.Text.Equals(""))
            {
                MessageBox.Show("Please, fill the necessary fields");
            }
            else
            {
                try {     
                    string query = "UPDATE BookTable SET ISBN=@ISBN, Title=@Title, Type=@Type, Status=@Status, Genre=@Genre, Publisher=@Publisher, PublDate=@PublDate, Description=@Desc WHERE ISBN=@ISBN";

                    using (conn = new SqlConnection(@"Data Source=LAPTOP-1U7ATFF0\SQLEXPRESSNEW;Initial Catalog=DatabaseLibrary;Integrated Security=True;"))
                    using (SqlCommand sc = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        sc.Parameters.AddWithValue("@ISBN", txtISBNFind.Text);
                        sc.Parameters.AddWithValue("@Title", txtTitleFind.Text);
                        sc.Parameters.AddWithValue("@Type", cmbxTypeChange.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Status", cmbxStatusChange.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Genre", cmbxGenreChange.SelectedItem.ToString());
                        sc.Parameters.AddWithValue("@Publisher", txtPublisherFind.Text);
                        sc.Parameters.AddWithValue("@PublDate", dtpChange.Value);
                        sc.Parameters.AddWithValue("@Desc", rtxtbxDescFind.Text);

                        sc.ExecuteScalar();

                        MessageBox.Show("Record with ISBN: " + txtISBNFind.Text + " was changed", "Database");
                    }
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
        }
    }
}
