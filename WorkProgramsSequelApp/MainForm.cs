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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            var dbForm = new DataBaseForm();
            dbForm.ShowDialog();
        }

        private void buttonSelectDoc_Click(object sender, EventArgs e)
        {
            var genForm = new GenerateForm();
            genForm.ShowDialog();
        }
    }
}
