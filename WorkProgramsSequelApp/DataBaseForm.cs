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
        DataSet ds = new DataSet();

        public DataBaseForm()
        {
            InitializeComponent();
            dataGridViewEmp.ReadOnly = true;
            dataGridViewSyl.ReadOnly = true;
            dataGridViewDisc.ReadOnly = true;
            dataGridViewWL.ReadOnly = true;
            FillData();
        }

        private void FillData()
        {
            DataBaseWorker.OpenConnection();
            ds.Tables.Add(DataBaseWorker.ExecuteQuery("SELECT * FROM Employees"));
            ds.Tables.Add(DataBaseWorker.ExecuteQuery("SELECT * FROM Syllabuses"));
            ds.Tables.Add(DataBaseWorker.ExecuteQuery("SELECT Id, Name, Competencies FROM Disciplines"));
            ds.Tables.Add(DataBaseWorker.ExecuteQuery("SELECT * FROM Workload"));
            dataGridViewEmp.DataSource = ds.Tables[0];
            dataGridViewSyl.DataSource = ds.Tables[1];
            dataGridViewDisc.DataSource = ds.Tables[2];
            dataGridViewWL.DataSource = ds.Tables[3];
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
            buttonSaveDB.Enabled = true;
        }

        private void buttonSaveDB_Click(object sender, EventArgs e)
        {
            buttonSaveDB.Enabled = false;
        }
    }
}
