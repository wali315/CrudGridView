using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CrudGridView
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CLARK2666;Initial Catalog=CrudWinFormSP;Integrated Security=True;Encrypt = False");

        public Form1()
        {
            InitializeComponent();
            GetEmpList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBoxEmployeeID.Text);
            string empname = (textBoxEmployeeName.Text), city = (textBoxCity.Text), contact = (textBoxContact.Text), gender = "";
            double age = double.Parse(textBoxAge.Text);
            DateTime joiningdate = DateTime.Parse(dateTimePickerJoiningDate.Text);
            if (radioButtonMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            con.Open();

            // Use parameterized query to prevent SQL injection
            using (SqlCommand cmd = new SqlCommand("InsertEmp_SP", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@EmployeeID", empid);
                cmd.Parameters.AddWithValue("@EmployeeName", empname);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@JoiningDate", joiningdate);

                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Succesfully Inserted");
            GetEmpList();
        }

        void GetEmpList()
        {
            con.Open();
            using (SqlCommand cmd = new SqlCommand("ListEmp_SP", con))
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            con.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBoxEmployeeID.Text);
            string empname = (textBoxEmployeeName.Text), city = (textBoxCity.Text), contact = (textBoxContact.Text), gender = "";
            double age = double.Parse(textBoxAge.Text);
            DateTime joiningdate = DateTime.Parse(dateTimePickerJoiningDate.Text);
            if (radioButtonMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            con.Open();

            // Use parameterized query to prevent SQL injection
            using (SqlCommand cmd = new SqlCommand("UpdateEmp_SP", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters to the command
                cmd.Parameters.AddWithValue("@EmployeeID", empid);
                cmd.Parameters.AddWithValue("@EmployeeName", empname);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Contact", contact);
                cmd.Parameters.AddWithValue("@JoiningDate", joiningdate);

                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Succesfully Updated");
            GetEmpList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Delete?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int empid = int.Parse(textBoxEmployeeID.Text);
                con.Open();

                // Use parameterized query to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand("DeleteEmp_SP", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters to the command
                    cmd.Parameters.AddWithValue("@EmployeeID", empid);

                    cmd.ExecuteNonQuery();
                }
                con.Close();
                MessageBox.Show("Succesfully Deleted");
                GetEmpList();
            }
        }

        // Load Specific Employee
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int empid = int.Parse(textBoxEmployeeID.Text);
            // Use parameterized query to prevent SQL injection
            using (SqlCommand cmd = new SqlCommand("LoadEmp_SP", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                // Add parameters to the command
                cmd.Parameters.AddWithValue("@EmployeeID", empid);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            
        }
    }
}