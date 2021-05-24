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

        public DataBaseForm()
        {
            InitializeComponent();
            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmp.AllowUserToAddRows = false;
            dataGridViewSyl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSyl.AllowUserToAddRows = false;

            DataBaseWorker.OpenConnection();
            ds1 = DataBaseWorker.ExecuteQuery("SELECT * FROM Employees");
            ds2 = DataBaseWorker.ExecuteQuery("SELECT * FROM Syllabuses");
            dataGridViewEmp.DataSource = ds1.Tables[0];
            dataGridViewEmp.ReadOnly = true;
            dataGridViewSyl.DataSource = ds2.Tables[0];
            dataGridViewSyl.ReadOnly = true;
            DataBaseWorker.CloseConnection();
        }
    }
}
