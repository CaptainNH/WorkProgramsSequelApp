﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkProgramsSequelApp
{
    public partial class GenerateForm : Form
    {
        public GenerateForm()
        {
            InitializeComponent();
            SetSubjects();
        }

        private void SetSubjects()
        {
            DataBaseWorker.OpenConnection();
            var items = DataBaseWorker.ExecuteQuery("SELECT Name FROM Disciplines");
            DataBaseWorker.CloseConnection();
            string[] arr = items.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToArray();
            comboBoxDiscipline.Items.AddRange(arr);
        }
    }
}