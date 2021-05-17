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

namespace WorkProgramsSequelApp
{
    public partial class DataBaseForm : Form
    {
        DataSet ds1;
        DataSet ds2;
        SqlDataAdapter adapterEmp;
        SqlDataAdapter adapterSyl;

        public DataBaseForm(string connectionString)
        {
            InitializeComponent();
            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmp.AllowUserToAddRows = false;
            dataGridViewSyl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSyl.AllowUserToAddRows = false;

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                adapterEmp = new SqlDataAdapter("SELECT * FROM Employees", connection);
                adapterSyl = new SqlDataAdapter("SELECT * FROM Syllabuses", connection);
                ds1 = new DataSet();
                ds2 = new DataSet();
                adapterEmp.Fill(ds1);
                adapterSyl.Fill(ds2);
                dataGridViewEmp.DataSource = ds1.Tables[0];
                dataGridViewEmp.Columns["Id"].ReadOnly = true;
                dataGridViewSyl.DataSource = ds2.Tables[0];
                dataGridViewSyl.Columns["Id"].ReadOnly = true;
            }
        }
    }
}
