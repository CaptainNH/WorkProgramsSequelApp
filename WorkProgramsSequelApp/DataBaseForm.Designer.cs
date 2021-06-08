namespace WorkProgramsSequelApp
{
    partial class DataBaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSaveDB = new System.Windows.Forms.Button();
            this.buttonChangeDB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.tabSyllabuses = new System.Windows.Forms.TabPage();
            this.dataGridViewSyl = new System.Windows.Forms.DataGridView();
            this.tabDisciplines = new System.Windows.Forms.TabPage();
            this.dataGridViewDisc = new System.Windows.Forms.DataGridView();
            this.tabPageWL = new System.Windows.Forms.TabPage();
            this.dataGridViewWL = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            this.tabSyllabuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyl)).BeginInit();
            this.tabDisciplines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisc)).BeginInit();
            this.tabPageWL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWL)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.buttonSaveDB);
            this.panel2.Controls.Add(this.buttonChangeDB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 48);
            this.panel2.TabIndex = 1;
            // 
            // buttonSaveDB
            // 
            this.buttonSaveDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveDB.Enabled = false;
            this.buttonSaveDB.Location = new System.Drawing.Point(919, 6);
            this.buttonSaveDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSaveDB.Name = "buttonSaveDB";
            this.buttonSaveDB.Size = new System.Drawing.Size(133, 37);
            this.buttonSaveDB.TabIndex = 1;
            this.buttonSaveDB.Text = "Сохранить";
            this.buttonSaveDB.UseVisualStyleBackColor = true;
            this.buttonSaveDB.Click += new System.EventHandler(this.buttonSaveDB_Click);
            // 
            // buttonChangeDB
            // 
            this.buttonChangeDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeDB.Location = new System.Drawing.Point(780, 6);
            this.buttonChangeDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangeDB.Name = "buttonChangeDB";
            this.buttonChangeDB.Size = new System.Drawing.Size(133, 37);
            this.buttonChangeDB.TabIndex = 0;
            this.buttonChangeDB.Text = "Редактировать";
            this.buttonChangeDB.UseVisualStyleBackColor = true;
            this.buttonChangeDB.Click += new System.EventHandler(this.buttonChangeDB_Click);
            this.buttonChangeDB.MouseHover += new System.EventHandler(this.buttonChangeDB_MouseHover);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 506);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabSyllabuses);
            this.tabControl1.Controls.Add(this.tabDisciplines);
            this.tabControl1.Controls.Add(this.tabPageWL);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dataGridViewEmp);
            this.tabEmployees.Location = new System.Drawing.Point(4, 25);
            this.tabEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEmployees.Size = new System.Drawing.Size(1059, 477);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Сотрудники";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AllowUserToAddRows = false;
            this.dataGridViewEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmp.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewEmp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.RowHeadersWidth = 51;
            this.dataGridViewEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmp.Size = new System.Drawing.Size(1051, 469);
            this.dataGridViewEmp.TabIndex = 0;
            // 
            // tabSyllabuses
            // 
            this.tabSyllabuses.Controls.Add(this.dataGridViewSyl);
            this.tabSyllabuses.Location = new System.Drawing.Point(4, 25);
            this.tabSyllabuses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSyllabuses.Name = "tabSyllabuses";
            this.tabSyllabuses.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSyllabuses.Size = new System.Drawing.Size(1059, 477);
            this.tabSyllabuses.TabIndex = 1;
            this.tabSyllabuses.Text = "Учебные планы";
            this.tabSyllabuses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSyl
            // 
            this.dataGridViewSyl.AllowUserToAddRows = false;
            this.dataGridViewSyl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSyl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSyl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSyl.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewSyl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewSyl.Name = "dataGridViewSyl";
            this.dataGridViewSyl.RowHeadersWidth = 51;
            this.dataGridViewSyl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSyl.Size = new System.Drawing.Size(1051, 469);
            this.dataGridViewSyl.TabIndex = 0;
            // 
            // tabDisciplines
            // 
            this.tabDisciplines.Controls.Add(this.dataGridViewDisc);
            this.tabDisciplines.Location = new System.Drawing.Point(4, 25);
            this.tabDisciplines.Name = "tabDisciplines";
            this.tabDisciplines.Size = new System.Drawing.Size(1059, 477);
            this.tabDisciplines.TabIndex = 2;
            this.tabDisciplines.Text = "Дисциплины";
            this.tabDisciplines.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDisc
            // 
            this.dataGridViewDisc.AllowUserToAddRows = false;
            this.dataGridViewDisc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisc.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDisc.Name = "dataGridViewDisc";
            this.dataGridViewDisc.RowHeadersWidth = 51;
            this.dataGridViewDisc.RowTemplate.Height = 24;
            this.dataGridViewDisc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisc.Size = new System.Drawing.Size(1059, 477);
            this.dataGridViewDisc.TabIndex = 0;
            // 
            // tabPageWL
            // 
            this.tabPageWL.Controls.Add(this.dataGridViewWL);
            this.tabPageWL.Location = new System.Drawing.Point(4, 25);
            this.tabPageWL.Name = "tabPageWL";
            this.tabPageWL.Size = new System.Drawing.Size(1059, 477);
            this.tabPageWL.TabIndex = 3;
            this.tabPageWL.Text = "Нагрузки";
            this.tabPageWL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWL
            // 
            this.dataGridViewWL.AllowUserToAddRows = false;
            this.dataGridViewWL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewWL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewWL.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWL.Name = "dataGridViewWL";
            this.dataGridViewWL.RowHeadersWidth = 51;
            this.dataGridViewWL.RowTemplate.Height = 24;
            this.dataGridViewWL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWL.Size = new System.Drawing.Size(1059, 477);
            this.dataGridViewWL.TabIndex = 0;
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataBaseForm";
            this.Text = "Рабочие программы";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            this.tabSyllabuses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyl)).EndInit();
            this.tabDisciplines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisc)).EndInit();
            this.tabPageWL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmp;
        private System.Windows.Forms.TabPage tabSyllabuses;
        private System.Windows.Forms.DataGridView dataGridViewSyl;
        private System.Windows.Forms.Button buttonChangeDB;
        private System.Windows.Forms.Button buttonSaveDB;
        private System.Windows.Forms.TabPage tabDisciplines;
        private System.Windows.Forms.DataGridView dataGridViewDisc;
        private System.Windows.Forms.TabPage tabPageWL;
        private System.Windows.Forms.DataGridView dataGridViewWL;
    }
}