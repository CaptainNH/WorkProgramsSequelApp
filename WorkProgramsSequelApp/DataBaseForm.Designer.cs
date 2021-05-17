﻿namespace WorkProgramsSequelApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.tabSyllabuses = new System.Windows.Forms.TabPage();
            this.dataGridViewEmp = new System.Windows.Forms.DataGridView();
            this.dataGridViewSyl = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            this.tabSyllabuses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyl)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 93);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 357);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmployees);
            this.tabControl1.Controls.Add(this.tabSyllabuses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 357);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dataGridViewEmp);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(792, 331);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Сотрудники";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // tabSyllabuses
            // 
            this.tabSyllabuses.Controls.Add(this.dataGridViewSyl);
            this.tabSyllabuses.Location = new System.Drawing.Point(4, 22);
            this.tabSyllabuses.Name = "tabSyllabuses";
            this.tabSyllabuses.Padding = new System.Windows.Forms.Padding(3);
            this.tabSyllabuses.Size = new System.Drawing.Size(792, 331);
            this.tabSyllabuses.TabIndex = 1;
            this.tabSyllabuses.Text = "Учебные планы";
            this.tabSyllabuses.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmp
            // 
            this.dataGridViewEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmp.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmp.Name = "dataGridViewEmp";
            this.dataGridViewEmp.Size = new System.Drawing.Size(786, 325);
            this.dataGridViewEmp.TabIndex = 0;
            // 
            // dataGridViewSyl
            // 
            this.dataGridViewSyl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSyl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSyl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSyl.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSyl.Name = "dataGridViewSyl";
            this.dataGridViewSyl.Size = new System.Drawing.Size(786, 325);
            this.dataGridViewSyl.TabIndex = 0;
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "DataBaseForm";
            this.Text = "DataBaseForm";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabSyllabuses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSyl)).EndInit();
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
    }
}