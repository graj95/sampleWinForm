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

namespace sampleWinForm
{
    public partial class Form4 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form4()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
              try
              {
                //step2 write a query that needs to be fire
                string qry = "insert into Employee values(@name,@salary)";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtEmpSalary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from Employee where Id=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpid.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();// Name , Salary are the col names
                        txtEmpSalary.Text = dr["Salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "update Employee set Name=@name,Salary=@salary where Id=@id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtEmpSalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpid.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             try
              {
                //step2 write a query that needs to be fire
                string qry = "delete from Employee  where Id=@id";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpid.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record deleted");
                    txtEmpid.Clear();
                    txtName.Clear();
                    txtEmpSalary.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                //step2 write a query that needs to be fire
                string qry = "select * from Employee;";
                //step 3 assign qry to the command
                cmd = new SqlCommand(qry, con);
                // step 4  assign parameter value
               
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                 dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    EmpGridView.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Record not Found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSaveUsingSP_Click(object sender, EventArgs e)
        {
            try
            {
               
                //step 3 assign qry to the command
                cmd = new SqlCommand("sp_insert_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtEmpSalary.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdateUsingSP_Click(object sender, EventArgs e)
        {
            try
            {
                
                cmd = new SqlCommand("sp_update_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(txtEmpSalary.Text));
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpid.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record updated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void btnDeleteUsingSP_Click(object sender, EventArgs e)
        {
            try
            {
               

                //step 3 assign qry to the command
                cmd = new SqlCommand("sp_delete_Employee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                // step 4  assign parameter value
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtEmpid.Text));
                // step 5 open the connection to fire query
                con.Open();
                // step 6 fire the query
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Success ! Record deleted");
                    txtEmpid.Clear();
                    txtName.Clear();
                    txtEmpSalary.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
