namespace courses
{
    partial class View_Courses
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
            this.tvCourses = new System.Windows.Forms.DataGridView();
            this.tbNameCourse = new System.Windows.Forms.TextBox();
            this.tbTypeCourse = new System.Windows.Forms.TextBox();
            this.tbCountStudyDays = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // tvCourses
            // 
            this.tvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvCourses.Location = new System.Drawing.Point(273, 13);
            this.tvCourses.Name = "tvCourses";
            this.tvCourses.Size = new System.Drawing.Size(663, 332);
            this.tvCourses.TabIndex = 0;
            this.tvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbNameCourse
            // 
            this.tbNameCourse.Location = new System.Drawing.Point(31, 48);
            this.tbNameCourse.Name = "tbNameCourse";
            this.tbNameCourse.Size = new System.Drawing.Size(219, 20);
            this.tbNameCourse.TabIndex = 1;
            // 
            // tbTypeCourse
            // 
            this.tbTypeCourse.Location = new System.Drawing.Point(31, 87);
            this.tbTypeCourse.Name = "tbTypeCourse";
            this.tbTypeCourse.Size = new System.Drawing.Size(219, 20);
            this.tbTypeCourse.TabIndex = 2;
            // 
            // tbCountStudyDays
            // 
            this.tbCountStudyDays.Location = new System.Drawing.Point(31, 126);
            this.tbCountStudyDays.Name = "tbCountStudyDays";
            this.tbCountStudyDays.Size = new System.Drawing.Size(219, 20);
            this.tbCountStudyDays.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество дней обучения";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // View_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCountStudyDays);
            this.Controls.Add(this.tbTypeCourse);
            this.Controls.Add(this.tbNameCourse);
            this.Controls.Add(this.tvCourses);
            this.Name = "View_Courses";
            this.Text = "Управление курсами Оргранизации";
            this.Load += new System.EventHandler(this.CoursesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tvCourses;
        private System.Windows.Forms.TextBox tbNameCourse;
        private System.Windows.Forms.TextBox tbTypeCourse;
        private System.Windows.Forms.TextBox tbCountStudyDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}