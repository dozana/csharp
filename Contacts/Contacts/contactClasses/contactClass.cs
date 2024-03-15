using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts.contactClasses
{
    internal class contactClass
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        // SELECTING DATA FROM DATABASE
        public DataTable Select()
        {
            // step 1: database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                // step 2: writing sql query
                string sql = "SELECT * FROM tbl_contact";

                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        // INSERTING DATA INTO DATABASE
        public bool Insert(contactClass c)
        {
            // creating a default return type and setting its value to false
            bool isSuccess = false;

            // step 1: connect database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                // step 2: create a sql query to insert data
                string sql = "INSERT INTO tbl_contact(FirstName, LastName, Phone, Address, Gender) VALUES(@FirstName, @LastName, @Phone, @Address, @Gender)";

                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // create prameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                // connection open here
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the quey runs successfully then the values of the rows will be reater than zero else its value will be 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // UPDATE DATA IN DATABASE
        public bool Update(contactClass c)
        {
            // create a default reuturn type and set its default value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                // sql to update in our database
                string sql = "UPDATE tbl_contact FirstName=@FirstName, LastName=@LastName, Phone=@Phone, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // create parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                // open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the quey runs successfully then the values of the rows will be reater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        // DELETE DATA FROM DATABASE
        public bool Delete(contactClass c)
        {
            // create a default reuturn value and set its value to false
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                // sql to delete data
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // create parameter to delete value
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                // open connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                // If the quey runs successfully then the values of the rows will be reater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
