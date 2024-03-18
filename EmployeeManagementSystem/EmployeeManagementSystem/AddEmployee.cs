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
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-R150C1E\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;");

        public AddEmployee()
        {
            InitializeComponent();

            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            try
            {
                EmployeeData ed = new EmployeeData();
                List<EmployeeData> listData = ed.employeeListData();

                dataGridView1.DataSource = listData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_id.Text == "" ||
                addEmployee_fullName.Text == "" ||
                addEmployee_gender.Text == "" ||
                addEmployee_phoneNumber.Text == "" ||
                addEmployee_position.Text == "" ||
                addEmployee_status.Text == "" ||
                addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployee_id.Text.Trim());

                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO employees(employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status) " +
                                    "VALUES(@employeeID, @fullName, @gender, @contactNum, @position, @image, @salary, @insertDate, @status)";

                                string path = Path.Combine(@"C:\Users\_\Desktop\csharp\EmployeeManagementSystem\EmployeeManagementSystem\Directory\" + addEmployee_id.Text.Trim() + ".jpg");

                                string? directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *.png)|*.jpg;*.png";

                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            }
        }

        private void addEmployee_updateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
