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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDB = new System.Windows.Forms.Button();
            this.buttonSelectDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(524, 99);
            this.label1.TabIndex = 0;
            this.label1.Text = "MathFuck";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDB
            // 
            this.buttonDB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDB.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDB.Location = new System.Drawing.Point(124, 238);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(276, 60);
            this.buttonDB.TabIndex = 1;
            this.buttonDB.Text = "База данных";
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // buttonSelectDoc
            // 
            this.buttonSelectDoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSelectDoc.Location = new System.Drawing.Point(124, 357);
            this.buttonSelectDoc.Name = "buttonSelectDoc";
            this.buttonSelectDoc.Size = new System.Drawing.Size(276, 60);
            this.buttonSelectDoc.TabIndex = 2;
            this.buttonSelectDoc.Text = "Генерировать документ";
            this.buttonSelectDoc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 534);
            this.Controls.Add(this.buttonSelectDoc);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Документы матфака";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDB;
        private System.Windows.Forms.Button buttonSelectDoc;
    }
}

