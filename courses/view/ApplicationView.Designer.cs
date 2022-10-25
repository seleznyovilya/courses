namespace courses
{
    partial class ApplicationView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.tbNameOrg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddressOrg = new System.Windows.Forms.TextBox();
            this.tbNumbPhoneOrg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bStuff = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lvStuff = new System.Windows.Forms.ListView();
            this.tbDolzh = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 546);
            this.dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выберете курс";
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
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 477);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(255, 37);
            this.bAdd.TabIndex = 12;
            this.bAdd.Text = "Оформить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(12, 520);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(255, 38);
            this.bDel.TabIndex = 13;
            this.bDel.Text = "Удалить";
            this.bDel.UseVisualStyleBackColor = true;
            // 
            // tbNameOrg
            // 
            this.tbNameOrg.Location = new System.Drawing.Point(12, 29);
            this.tbNameOrg.Name = "tbNameOrg";
            this.tbNameOrg.Size = new System.Drawing.Size(255, 20);
            this.tbNameOrg.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Адрес";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Телефон";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "email";
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
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lvStuff);
            this.groupBox1.Controls.Add(this.tbDolzh);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Дожность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "ФИО";
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
            // tbDolzh
            // 
            this.tbDolzh.Location = new System.Drawing.Point(6, 71);
            this.tbDolzh.Name = "tbDolzh";
            this.tbDolzh.Size = new System.Drawing.Size(242, 20);
            this.tbDolzh.TabIndex = 19;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(6, 32);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(243, 20);
            this.tbFIO.TabIndex = 18;
            // 
            // ApplicationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 572);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbCourse);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbNumbPhoneOrg);
            this.Controls.Add(this.tbAddressOrg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNameOrg);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ApplicationView";
            this.Text = "Прием заявки на обучение";
            this.Load += new System.EventHandler(this.SendApplicationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.TextBox tbNameOrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddressOrg;
        private System.Windows.Forms.TextBox tbNumbPhoneOrg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bStuff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvStuff;
        private System.Windows.Forms.TextBox tbDolzh;
        private System.Windows.Forms.TextBox tbFIO;
    }
}