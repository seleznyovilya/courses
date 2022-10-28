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
            this.LBsurname_name_lastname = new System.Windows.Forms.TextBox();
            this.LBdate_of_bithday = new System.Windows.Forms.DateTimePicker();
            this.LBeducation = new System.Windows.Forms.TextBox();
            this.LBcategory = new System.Windows.Forms.TextBox();
            this.lsurname_name_lastname = new System.Windows.Forms.Label();
            this.ldate_of_bithday = new System.Windows.Forms.Label();
            this.leducation = new System.Windows.Forms.Label();
            this.lcategory = new System.Windows.Forms.Label();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.lphone = new System.Windows.Forms.Label();
            this.LBnuberphone = new System.Windows.Forms.ComboBox();
            this.bUpdate = new System.Windows.Forms.Button();
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
            // LBsurname_name_lastname
            // 
            this.LBsurname_name_lastname.Location = new System.Drawing.Point(12, 30);
            this.LBsurname_name_lastname.Name = "LBsurname_name_lastname";
            this.LBsurname_name_lastname.Size = new System.Drawing.Size(165, 20);
            this.LBsurname_name_lastname.TabIndex = 1;
            // 
            // LBdate_of_bithday
            // 
            this.LBdate_of_bithday.CustomFormat = "yyyy-MM-dd";
            this.LBdate_of_bithday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LBdate_of_bithday.Location = new System.Drawing.Point(12, 78);
            this.LBdate_of_bithday.Name = "LBdate_of_bithday";
            this.LBdate_of_bithday.Size = new System.Drawing.Size(165, 20);
            this.LBdate_of_bithday.TabIndex = 2;
            // 
            // LBeducation
            // 
            this.LBeducation.Location = new System.Drawing.Point(13, 162);
            this.LBeducation.Name = "LBeducation";
            this.LBeducation.Size = new System.Drawing.Size(164, 20);
            this.LBeducation.TabIndex = 4;
            // 
            // LBcategory
            // 
            this.LBcategory.Location = new System.Drawing.Point(13, 201);
            this.LBcategory.Name = "LBcategory";
            this.LBcategory.Size = new System.Drawing.Size(164, 20);
            this.LBcategory.TabIndex = 5;
            // 
            // lsurname_name_lastname
            // 
            this.lsurname_name_lastname.AutoSize = true;
            this.lsurname_name_lastname.Location = new System.Drawing.Point(12, 12);
            this.lsurname_name_lastname.Name = "lsurname_name_lastname";
            this.lsurname_name_lastname.Size = new System.Drawing.Size(34, 13);
            this.lsurname_name_lastname.TabIndex = 6;
            this.lsurname_name_lastname.Text = "ФИО";
            this.lsurname_name_lastname.Click += new System.EventHandler(this.label1_Click);
            // 
            // ldate_of_bithday
            // 
            this.ldate_of_bithday.AutoSize = true;
            this.ldate_of_bithday.Location = new System.Drawing.Point(9, 62);
            this.ldate_of_bithday.Name = "ldate_of_bithday";
            this.ldate_of_bithday.Size = new System.Drawing.Size(86, 13);
            this.ldate_of_bithday.TabIndex = 7;
            this.ldate_of_bithday.Text = "Дата рождения";
            // 
            // leducation
            // 
            this.leducation.AutoSize = true;
            this.leducation.Location = new System.Drawing.Point(10, 146);
            this.leducation.Name = "leducation";
            this.leducation.Size = new System.Drawing.Size(75, 13);
            this.leducation.TabIndex = 9;
            this.leducation.Text = "Образование";
            // 
            // lcategory
            // 
            this.lcategory.AutoSize = true;
            this.lcategory.Location = new System.Drawing.Point(12, 185);
            this.lcategory.Name = "lcategory";
            this.lcategory.Size = new System.Drawing.Size(60, 13);
            this.lcategory.TabIndex = 10;
            this.lcategory.Text = "Категория";
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(15, 347);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(162, 23);
            this.bNew.TabIndex = 11;
            this.bNew.Text = "Добавить";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(15, 402);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(162, 23);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // lphone
            // 
            this.lphone.AutoSize = true;
            this.lphone.Location = new System.Drawing.Point(9, 102);
            this.lphone.Name = "lphone";
            this.lphone.Size = new System.Drawing.Size(27, 13);
            this.lphone.TabIndex = 8;
            this.lphone.Text = "Пол";
            // 
            // LBnuberphone
            // 
            this.LBnuberphone.FormattingEnabled = true;
            this.LBnuberphone.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.LBnuberphone.Location = new System.Drawing.Point(12, 118);
            this.LBnuberphone.Name = "LBnuberphone";
            this.LBnuberphone.Size = new System.Drawing.Size(165, 21);
            this.LBnuberphone.TabIndex = 3;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(15, 373);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(162, 23);
            this.bUpdate.TabIndex = 13;
            this.bUpdate.Text = "Добавить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // View_Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 447);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.lcategory);
            this.Controls.Add(this.leducation);
            this.Controls.Add(this.lphone);
            this.Controls.Add(this.ldate_of_bithday);
            this.Controls.Add(this.lsurname_name_lastname);
            this.Controls.Add(this.LBcategory);
            this.Controls.Add(this.LBeducation);
            this.Controls.Add(this.LBnuberphone);
            this.Controls.Add(this.LBdate_of_bithday);
            this.Controls.Add(this.LBsurname_name_lastname);
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
        private System.Windows.Forms.TextBox LBsurname_name_lastname;
        private System.Windows.Forms.DateTimePicker LBdate_of_bithday;
        private System.Windows.Forms.TextBox LBeducation;
        private System.Windows.Forms.TextBox LBcategory;
        private System.Windows.Forms.Label lsurname_name_lastname;
        private System.Windows.Forms.Label ldate_of_bithday;
        private System.Windows.Forms.Label leducation;
        private System.Windows.Forms.Label lcategory;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label lphone;
        private System.Windows.Forms.ComboBox LBnuberphone;
        private System.Windows.Forms.Button bUpdate;
    }
}