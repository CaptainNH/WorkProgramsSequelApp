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
        DataSet ds;

        public DataBaseForm()
        {
            InitializeComponent();
            dataGridViewEmp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmp.AllowUserToAddRows = false;
            dataGridViewSyl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSyl.AllowUserToAddRows = false;

            DataBaseWorker.OpenConnection();
            DataTable dsEmp = DataBaseWorker.ExecuteQuery("SELECT * FROM Employees");
            DataTable dsSyl = DataBaseWorker.ExecuteQuery("SELECT * FROM Syllabuses");
            dataGridViewEmp.DataSource = dsEmp;
            dataGridViewEmp.ReadOnly = true;
            dataGridViewSyl.DataSource = dsSyl;
            dataGridViewSyl.ReadOnly = true;
            DataBaseWorker.CloseConnection();
        }

        private void buttonChangeDB_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(buttonChangeDB, "Открывает таблицы для редактирования");
        }

        private void buttonChangeDB_Click(object sender, EventArgs e)
        {
            dataGridViewEmp.ReadOnly = false;
            dataGridViewSyl.ReadOnly = false;
            buttonSaveDB.Visible = true;
        }

        private void buttonSaveDB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
