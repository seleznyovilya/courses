namespace courses
{
    partial class View_Application
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tvApplication = new System.Windows.Forms.DataGridView();
            this.lname_of_organization = new System.Windows.Forms.Label();
            this.lname_of_course = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.LBname_of_organization = new System.Windows.Forms.TextBox();
            this.laddress_of_organization = new System.Windows.Forms.Label();
            this.tbAddressOrg = new System.Windows.Forms.TextBox();
            this.tbNumbPhoneOrg = new System.Windows.Forms.TextBox();
            this.lnumberphone = new System.Windows.Forms.Label();
            this.lemail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bStuff = new System.Windows.Forms.Button();
            this.lstuff_position = new System.Windows.Forms.Label();
            this.lname_surname_lastname_stuff = new System.Windows.Forms.Label();
            this.lvStuff = new System.Windows.Forms.ListView();
            this.LBstuff_pozition = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.bUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvApplication)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 437);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // tvApplication
            // 
            this.tvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvApplication.Location = new System.Drawing.Point(273, 12);
            this.tvApplication.Name = "tvApplication";
            this.tvApplication.Size = new System.Drawing.Size(1197, 546);
            this.tvApplication.TabIndex = 6;
            // 
            // lname_of_organization
            // 
            this.lname_of_organization.AutoSize = true;
            this.lname_of_organization.Location = new System.Drawing.Point(9, 12);
            this.lname_of_organization.Name = "lname_of_organization";
            this.lname_of_organization.Size = new System.Drawing.Size(151, 13);
            this.lname_of_organization.TabIndex = 7;
            this.lname_of_organization.Text = "Наименование организации";
            // 
            // lname_of_course
            // 
            this.lname_of_course.AutoSize = true;
            this.lname_of_course.Location = new System.Drawing.Point(9, 131);
            this.lname_of_course.Name = "lname_of_course";
            this.lname_of_course.Size = new System.Drawing.Size(83, 13);
            this.lname_of_course.TabIndex = 8;
            this.lname_of_course.Text = "Выберете курс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Желаемая дата \r\nначала обучения";
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(12, 477);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(255, 23);
            this.bNew.TabIndex = 12;
            this.bNew.Text = "Оформить";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(12, 532);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(255, 26);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // LBname_of_organization
            // 
            this.LBname_of_organization.Location = new System.Drawing.Point(12, 29);
            this.LBname_of_organization.Name = "LBname_of_organization";
            this.LBname_of_organization.Size = new System.Drawing.Size(255, 20);
            this.LBname_of_organization.TabIndex = 14;
            // 
            // laddress_of_organization
            // 
            this.laddress_of_organization.AutoSize = true;
            this.laddress_of_organization.Location = new System.Drawing.Point(9, 52);
            this.laddress_of_organization.Name = "laddress_of_organization";
            this.laddress_of_organization.Size = new System.Drawing.Size(38, 13);
            this.laddress_of_organization.TabIndex = 15;
            this.laddress_of_organization.Text = "Адрес";
            // 
            // tbAddressOrg
            // 
            this.tbAddressOrg.Location = new System.Drawing.Point(13, 69);
            this.tbAddressOrg.Name = "tbAddressOrg";
            this.tbAddressOrg.Size = new System.Drawing.Size(254, 20);
            this.tbAddressOrg.TabIndex = 16;
            // 
            // tbNumbPhoneOrg
            // 
            this.tbNumbPhoneOrg.Location = new System.Drawing.Point(12, 108);
            this.tbNumbPhoneOrg.Name = "tbNumbPhoneOrg";
            this.tbNumbPhoneOrg.Size = new System.Drawing.Size(111, 20);
            this.tbNumbPhoneOrg.TabIndex = 17;
            // 
            // lnumberphone
            // 
            this.lnumberphone.AutoSize = true;
            this.lnumberphone.Location = new System.Drawing.Point(9, 92);
            this.lnumberphone.Name = "lnumberphone";
            this.lnumberphone.Size = new System.Drawing.Size(52, 13);
            this.lnumberphone.TabIndex = 18;
            this.lnumberphone.Text = "Телефон";
            // 
            // lemail
            // 
            this.lemail.AutoSize = true;
            this.lemail.Location = new System.Drawing.Point(129, 92);
            this.lemail.Name = "lemail";
            this.lemail.Size = new System.Drawing.Size(31, 13);
            this.lemail.TabIndex = 19;
            this.lemail.Text = "email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(132, 108);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(135, 20);
            this.tbEmail.TabIndex = 20;
            // 
            // cbCourse
            // 
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Location = new System.Drawing.Point(12, 147);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(255, 21);
            this.cbCourse.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bStuff);
            this.groupBox1.Controls.Add(this.lstuff_position);
            this.groupBox1.Controls.Add(this.lname_surname_lastname_stuff);
            this.groupBox1.Controls.Add(this.lvStuff);
            this.groupBox1.Controls.Add(this.LBstuff_pozition);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Location = new System.Drawing.Point(12, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 231);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список сотрудников";
            // 
            // bStuff
            // 
            this.bStuff.Location = new System.Drawing.Point(45, 98);
            this.bStuff.Name = "bStuff";
            this.bStuff.Size = new System.Drawing.Size(161, 22);
            this.bStuff.TabIndex = 23;
            this.bStuff.Text = "Добавить в список";
            this.bStuff.UseVisualStyleBackColor = true;
            this.bStuff.Click += new System.EventHandler(this.button3_Click);
            // 
            // lstuff_position
            // 
            this.lstuff_position.AutoSize = true;
            this.lstuff_position.Location = new System.Drawing.Point(6, 55);
            this.lstuff_position.Name = "lstuff_position";
            this.lstuff_position.Size = new System.Drawing.Size(59, 13);
            this.lstuff_position.TabIndex = 25;
            this.lstuff_position.Text = "Дожность";
            // 
            // lname_surname_lastname_stuff
            // 
            this.lname_surname_lastname_stuff.AutoSize = true;
            this.lname_surname_lastname_stuff.Location = new System.Drawing.Point(6, 16);
            this.lname_surname_lastname_stuff.Name = "lname_surname_lastname_stuff";
            this.lname_surname_lastname_stuff.Size = new System.Drawing.Size(34, 13);
            this.lname_surname_lastname_stuff.TabIndex = 24;
            this.lname_surname_lastname_stuff.Text = "ФИО";
            // 
            // lvStuff
            // 
            this.lvStuff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvStuff.HideSelection = false;
            this.lvStuff.Location = new System.Drawing.Point(6, 126);
            this.lvStuff.Name = "lvStuff";
            this.lvStuff.Size = new System.Drawing.Size(243, 99);
            this.lvStuff.TabIndex = 20;
            this.lvStuff.UseCompatibleStateImageBehavior = false;
            this.lvStuff.View = System.Windows.Forms.View.List;
            // 
            // LBstuff_pozition
            // 
            this.LBstuff_pozition.Location = new System.Drawing.Point(6, 71);
            this.LBstuff_pozition.Name = "LBstuff_pozition";
            this.LBstuff_pozition.Size = new System.Drawing.Size(242, 20);
            this.LBstuff_pozition.TabIndex = 19;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(6, 32);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(243, 20);
            this.tbFIO.TabIndex = 18;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 505);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(255, 23);
            this.bUpdate.TabIndex = 23;
            this.bUpdate.Text = "Изменить";
            this.bUpdate.UseVisualStyleBackColor = true;
            // 
            // View_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 572);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lemail);
            this.Controls.Add(this.lnumberphone);
            this.Controls.Add(this.tbNumbPhoneOrg);
            this.Controls.Add(this.tbAddressOrg);
            this.Controls.Add(this.laddress_of_organization);
            this.Controls.Add(this.LBname_of_organization);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lname_of_course);
            this.Controls.Add(this.lname_of_organization);
            this.Controls.Add(this.tvApplication);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "View_Application";
            this.Text = "Прием заявки на обучение";
            this.Load += new System.EventHandler(this.SendApplicationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvApplication)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView tvApplication;
        private System.Windows.Forms.Label lname_of_organization;
        private System.Windows.Forms.Label lname_of_course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.TextBox LBname_of_organization;
        private System.Windows.Forms.Label laddress_of_organization;
        private System.Windows.Forms.TextBox tbAddressOrg;
        private System.Windows.Forms.TextBox tbNumbPhoneOrg;
        private System.Windows.Forms.Label lnumberphone;
        private System.Windows.Forms.Label lemail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bStuff;
        private System.Windows.Forms.Label lstuff_position;
        private System.Windows.Forms.Label lname_surname_lastname_stuff;
        private System.Windows.Forms.ListView lvStuff;
        private System.Windows.Forms.TextBox LBstuff_pozition;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Button bUpdate;
    }
}