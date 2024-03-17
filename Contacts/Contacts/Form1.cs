using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Contacts.contactClasses;
using System.Data.SqlClient;
using System.Configuration;

using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized; // Open the form in fullscreen mode
            //this.FormBorderStyle = FormBorderStyle.None; // Hide the window border
            //this.WindowState = FormWindowState.Normal; // Set the window state to normal to hide the taskbar
            this.StartPosition = FormStartPosition.CenterScreen; // Center the form on the screen
        }

        contactClass c = new contactClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text.Trim()))
            {
                errorProvider1.SetError(textBoxFirstName, "FirstName is requireds");
                return;
            } else
            {
                errorProvider1.SetError(textBoxFirstName, string.Empty);
            }

            // get the value from the input fields
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.Phone = textBoxPhone.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = cmbGender.Text;
            c.Email = textBoxEmail.Text;

            // Insert data into database
            bool success = c.Insert(c);
 
            if (success == true)
            {
                MessageBox.Show("New contact successfully inserted.");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Please try again.");
            }

            // Load data on data GridView
            LoadDataGridView();
        }

        private void Clear()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            cmbGender.Text = "";
            textBoxEmail.Text = "";
        }

        private void LoadDataGridView()
        {
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the data from textboxes
            c.ContactID = int.Parse(textBoxContactID.Text);
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.Phone = textBoxPhone.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = cmbGender.Text;
            c.Email = textBoxEmail.Text;

            // Update data in database
            bool success = c.Update(c);

            if(success == true)
            {
                MessageBox.Show("Contact has been successfully updated.");

                LoadDataGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to update contact. Try again.");
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the data from DataGridView and load it to the textboxes
            // Identify the row on which mouse is clicked
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxPhone.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
            textBoxEmail.Text = dgvContactList.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get data from the textbox
            c.ContactID = Convert.ToInt32(textBoxContactID.Text);

            // Delete data in database
            bool success = c.Delete(c);

            if (success == true)
            {
                MessageBox.Show("Contact has been successfully deleted.");

                LoadDataGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to delete contact. Try again.");
            }
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the value from the textbox
            string keyword = textBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Phone LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%' OR Gender LIKE '%" + keyword + "%' OR Email LIKE '%" + keyword + "%'", conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt;
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            if (dgvContactList.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                MExcel.Application.Workbooks.Add(Type.Missing);

                // Export column headers
                for (int i = 1; i <= dgvContactList.Columns.Count; i++)
                {
                    MExcel.Cells[1, i] = dgvContactList.Columns[i - 1].HeaderText;
                }

                // Export cell values
                for (int i = 0; i < dgvContactList.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvContactList.Columns.Count; j++)
                    {
                        DataGridViewCell cell = dgvContactList.Rows[i].Cells[j];
                        if (cell.Value != null)
                        {
                            MExcel.Cells[i + 2, j + 1] = cell.Value.ToString();
                        }
                        else
                        {
                            MExcel.Cells[i + 2, j + 1] = string.Empty; // or handle null values as needed
                        }
                    }
                }

                MExcel.Columns.AutoFit();
                MExcel.Rows.AutoFit();
                MExcel.Columns.Font.Size = 12;
                MExcel.Visible = true;
            }
            else
            {
                MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImportFromExcel_Click(object sender, EventArgs e)
        {
            
        }

    }
}
