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
    public partial class Form5 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder scb;
        DataSet ds;
        public Form5()
        {
            InitializeComponent();
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }
        public DataSet GetAllEmps()
        {
            da = new SqlDataAdapter("select * from Employee", con);
            // assign PK to the col which in the DataSet
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            // emp is a table name given which is in the DataSet
            da.Fill(ds, "emp");// Fill method fire the select qry
            return ds;
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].NewRow();
                row["Name"] = txtName.Text;
                row["Salary"] = txtEmpSalary.Text;
                // attach the new row to the ds
                ds.Tables["emp"].Rows.Add(row);
                //update() will reflect the changes to the DB
                int result = da.Update(ds.Tables["emp"]);
                if (result == 1)
                {
                    MessageBox.Show("Success ! Recored inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpid.Text);
                if (row != null)
                {
                    row["Name"] = txtName.Text;
                    row["Salary"] = txtEmpSalary.Text;
                   
                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored updated");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpid.Text);
                if (row != null)
                {
                    row.Delete();

                    //update() will reflect the changes to the DB
                    int result = da.Update(ds.Tables["emp"]);
                    if (result == 1)
                    {
                        MessageBox.Show("Success ! Recored deleted");
                        txtEmpid.Clear();
                        txtName.Clear();
                        txtEmpSalary.Clear();
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmps();
                DataRow row = ds.Tables["emp"].Rows.Find(txtEmpid.Text);
                if (row != null)
                {
                    txtName.Text = row["Name"].ToString();
                    txtEmpSalary.Text = row["Salary"].ToString();

                   
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

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = GetAllEmps();
            EmpGridView.DataSource = ds.Tables["emp"];
        }
    }
}
