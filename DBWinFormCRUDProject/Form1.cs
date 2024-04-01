using Google.Protobuf.WellKnownTypes;
using MySqlConnector;
using Mysqlx.Crud;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DBWinFormCRUDProject

{
    public partial class Form1 : Form
    {
        public Database MYDB;
        public MySqlConnection mySqlConnection;

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCntDB_Click(object sender, EventArgs e)
        {
            mySqlConnection = MYDB.Connect();
            mySqlConnection.Open();
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show(" Connected to Database successfully!!!", "Database Connection", MessageBoxButtons.OK);

                btnCntDB.Enabled = false;
                btnDiscont.Enabled = true;
                btnDlt.Enabled = true;
                btnEdit.Enabled = true;
                btnInsert.Enabled = true;
                btnSrch.Enabled = true;
                btnLoadAll.Enabled = true;

            }
            else
            {
                MessageBox.Show(" Error in Connection to Database", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            MYDB = new Database("localhost", "root", "admin", "testdb", "3308");
            

        }

        private void btnConTst_Click(object sender, EventArgs e)
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show(" Connection is Valid!!!", "Database Connection", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(" No Valid Conenction", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscont_Click(object sender, EventArgs e)
        {
            if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
            {
                mySqlConnection.Close();
                MessageBox.Show(" Connection Closed!!!", "Database Connection", MessageBoxButtons.OK);

                btnCntDB.Enabled = true;
                btnDiscont.Enabled = false;
                btnDlt.Enabled = false;
                btnEdit.Enabled = false;
                btnInsert.Enabled = false;
                btnSrch.Enabled = false;
                btnLoadAll.Enabled = false;

            }

        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" Are you Sure?", "Exit Application", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                if (mySqlConnection != null)
                    mySqlConnection.Close();
                Application.Exit();
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            LoadAlldata();

        }

        private void btnClearNew_Click(object sender, EventArgs e)
        {
            txtnewBookISBN.Text = string.Empty;
            txtnewBookTitle.Text = string.Empty;
            txtnewBookAuthor.Text = string.Empty;
            txtnewBookPrice.Text = string.Empty;


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int newWidth = this.Width + panelInsertNewBook.Width + 100;
            this.Size = new Size(newWidth, this.Height);

            panelInsertNewBook.Visible = true;

        }

        private void btnInsertCancel_Click(object sender, EventArgs e)
        {
            int newWidth = this.Width - panelInsertNewBook.Width - 100;
            this.Size = new Size(newWidth, this.Height);
            panelInsertNewBook.Visible = false;

        }

        private void btnInsertNew_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(txtnewBookISBN.Text);
                String title = txtnewBookTitle.Text;
                String author = txtnewBookAuthor.Text;
                double price = Convert.ToDouble(txtnewBookPrice.Text);

                String qStr = $"insert into booktable values ({isbn}, '{title}', '{author}',{price})";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                txtnewBookISBN.Text = "";
                txtnewBookTitle.Text = "";
                txtnewBookAuthor.Text = "";
                txtnewBookPrice.Text = "";

                MessageBox.Show(" New book Inserted to the table successfully!!!", "New Book", MessageBoxButtons.OK);
                // refresh the datagridview

                LoadAlldata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }
        }

        // this method added as it will be needed after all CRUD operations
        public void LoadAlldata()
        {
            try
            {
                String qStr = "select * from booktable";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridAll.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error in Database Operation", "Error", MessageBoxButtons.OK);
            }

        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(" Are you Sure?", "Exit Application", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                if (dataGridAll.SelectedRows.Count > 0)
                {
                    try
                    {
                        // Get the selected row
                        DataGridViewRow selectedRow = dataGridAll.SelectedRows[0];
                        int isbn = Convert.ToInt16(selectedRow.Cells["ISBN"].Value);
                        String qStr = $"delete from booktable where ISBN = {isbn}";
                        MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                        mySqlCommand.ExecuteNonQuery();
                        MessageBox.Show(" Selected book Deleted from the table successfully!!!", "Delete Book", MessageBoxButtons.OK);

                        // refresh the datagridview
                        LoadAlldata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($" Error in Database Operation : {ex.Message}", "Error", MessageBoxButtons.OK);
                    }
                }
                else
                {

                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            // Check if a row is selected

        }

        private void btnClrEdit_Click(object sender, EventArgs e)
        {
            txtEditBookISBN.Text = string.Empty;
            txtEditBookTitle.Text = string.Empty;
            txtEditBookAuthor.Text = string.Empty;
            txtEditBookPrice.Text = string.Empty;
        }

        private void btncancelEdit_Click(object sender, EventArgs e)
        {
            int newWidth = this.Width - panelEditBook.Width - 100;
            this.Size = new Size(newWidth, this.Height);
            panelEditBook.Visible = false;
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            try
            {
                int isbn = Convert.ToInt32(txtEditBookISBN.Text);
                String title = txtEditBookTitle.Text;
                String author = txtEditBookAuthor.Text;
                double price = Convert.ToDouble(txtEditBookPrice.Text);

                String qStr = $"update booktable set ISBN ={isbn},  Title = '{title}', Author= '{author}' ,Price={price} where ISBN = {isbn}";
                MySqlCommand mySqlCommand = new MySqlCommand(qStr, mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                txtnewBookISBN.Text = "";
                txtnewBookTitle.Text = "";
                txtnewBookAuthor.Text = "";
                txtnewBookPrice.Text = "";

                MessageBox.Show(" The Selected book Updatedsuccessfully!!!", "New Book", MessageBoxButtons.OK);
                // refresh the datagridview

                LoadAlldata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Error in Database Operation : {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridAll.SelectedRows.Count > 0)
            {
                int newWidth = this.Width + panelEditBook.Width + 100;
                this.Size = new Size(newWidth, this.Height);

                panelEditBook.Visible = true;

                DataGridViewRow selectedRow = dataGridAll.SelectedRows[0];
                int isbn = Convert.ToInt16(selectedRow.Cells["ISBN"].Value);
                String title = selectedRow.Cells["Title"].Value.ToString();
                String author = selectedRow.Cells["Author"].Value.ToString();
                double price = Convert.ToDouble(selectedRow.Cells["Price"].Value);

                txtEditBookTitle.Text = title;
                txtEditBookAuthor.Text = author;
                txtEditBookISBN.Text = isbn + "";
                txtEditBookPrice.Text = price + "";

                txtEditBookISBN.Enabled = false;

            }
            else
            {

                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
