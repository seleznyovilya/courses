namespace courses
{
    partial class View_Teachers
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
            this.tvTeachers = new System.Windows.Forms.DataGridView();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.dtpBithday = new System.Windows.Forms.DateTimePicker();
            this.tbEducation = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // tvTeachers
            // 
            this.tvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvTeachers.Location = new System.Drawing.Point(183, 12);
            this.tvTeachers.Name = "tvTeachers";
            this.tvTeachers.Size = new System.Drawing.Size(834, 411);
            this.tvTeachers.TabIndex = 0;
            this.tvTeachers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(12, 30);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(165, 20);
            this.tbFIO.TabIndex = 1;
            // 
            // dtpBithday
            // 
            this.dtpBithday.CustomFormat = "yyyy-MM-dd";
            this.dtpBithday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBithday.Location = new System.Drawing.Point(12, 78);
            this.dtpBithday.Name = "dtpBithday";
            this.dtpBithday.Size = new System.Drawing.Size(165, 20);
            this.dtpBithday.TabIndex = 2;
            // 
            // tbEducation
            // 
            this.tbEducation.Location = new System.Drawing.Point(13, 162);
            this.tbEducation.Name = "tbEducation";
            this.tbEducation.Size = new System.Drawing.Size(164, 20);
            this.tbEducation.TabIndex = 4;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(13, 201);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(164, 20);
            this.tbCategory.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Образование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Категория";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(15, 386);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(162, 23);
            this.btnAddTeacher.TabIndex = 11;
            this.btnAddTeacher.Text = "Добавить";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пол";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cbGender.Location = new System.Drawing.Point(12, 118);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(165, 21);
            this.cbGender.TabIndex = 3;
            // 
            // View_Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.tbEducation);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtpBithday);
            this.Controls.Add(this.tbFIO);
            this.Controls.Add(this.tvTeachers);
            this.Name = "View_Teachers";
            this.Text = "Управление преподавателями";
            this.Load += new System.EventHandler(this.TeachersView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tvTeachers;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.DateTimePicker dtpBithday;
        private System.Windows.Forms.TextBox tbEducation;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGender;
    }
}