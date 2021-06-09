namespace WorkProgramsSequelApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDB = new System.Windows.Forms.Button();
            this.buttonSelectDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 115);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рабочие программы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDB
            // 
            this.buttonDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDB.AutoSize = true;
            this.buttonDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDB.Location = new System.Drawing.Point(90, 139);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(300, 60);
            this.buttonDB.TabIndex = 1;
            this.buttonDB.Text = "База данных";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // buttonSelectDoc
            // 
            this.buttonSelectDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSelectDoc.AutoSize = true;
            this.buttonSelectDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelectDoc.Location = new System.Drawing.Point(90, 224);
            this.buttonSelectDoc.Name = "buttonSelectDoc";
            this.buttonSelectDoc.Size = new System.Drawing.Size(300, 60);
            this.buttonSelectDoc.TabIndex = 2;
            this.buttonSelectDoc.Text = "Генерировать документ";
            this.buttonSelectDoc.UseVisualStyleBackColor = true;
            this.buttonSelectDoc.Click += new System.EventHandler(this.buttonSelectDoc_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 320);
            this.Controls.Add(this.buttonSelectDoc);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Рабочие программы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDB;
        private System.Windows.Forms.Button buttonSelectDoc;
    }
}

