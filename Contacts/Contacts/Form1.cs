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

namespace Contacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get the value from the input fields
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.Phone = textBoxPhone.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = cmbGender.Text;

            // Insert data into database
            bool success = c.Insert(c);
 
            if (success == true)
            {
                MessageBox.Show("New contact successfully inserted.");
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Failed to add new contact. Please try again.");
            }

            // Load data on data GridView
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void ClearInputFields()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            cmbGender.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data on data GridView
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
    }
}
