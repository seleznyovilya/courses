namespace courses
{
    partial class MainView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bGetApplication = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnConsolidation = new System.Windows.Forms.Button();
            this.bTeacher = new System.Windows.Forms.Button();
            this.bCourses = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bGetApplication);
            this.groupBox1.Controls.Add(this.btnPrice);
            this.groupBox1.Controls.Add(this.btnConsolidation);
            this.groupBox1.Controls.Add(this.bTeacher);
            this.groupBox1.Controls.Add(this.bCourses);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление курсами своей Организации";
            // 
            // bGetApplication
            // 
            this.bGetApplication.Location = new System.Drawing.Point(269, 19);
            this.bGetApplication.Name = "bGetApplication";
            this.bGetApplication.Size = new System.Drawing.Size(131, 109);
            this.bGetApplication.TabIndex = 4;
            this.bGetApplication.Text = "Прием заявок на обучение";
            this.bGetApplication.UseVisualStyleBackColor = true;
            this.bGetApplication.Click += new System.EventHandler(this.bGetApplication_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(6, 79);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(121, 49);
            this.btnPrice.TabIndex = 3;
            this.btnPrice.Text = "Управление ценами на курс";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnConsolidation
            // 
            this.btnConsolidation.Location = new System.Drawing.Point(133, 79);
            this.btnConsolidation.Name = "btnConsolidation";
            this.btnConsolidation.Size = new System.Drawing.Size(131, 49);
            this.btnConsolidation.TabIndex = 2;
            this.btnConsolidation.Text = "Закрепление преподавателей за курсами";
            this.btnConsolidation.UseVisualStyleBackColor = true;
            this.btnConsolidation.Click += new System.EventHandler(this.btnConsolidation_Click);
            // 
            // bTeacher
            // 
            this.bTeacher.Location = new System.Drawing.Point(133, 19);
            this.bTeacher.Name = "bTeacher";
            this.bTeacher.Size = new System.Drawing.Size(130, 54);
            this.bTeacher.TabIndex = 1;
            this.bTeacher.Text = "Управление преподавателями";
            this.bTeacher.UseVisualStyleBackColor = true;
            this.bTeacher.Click += new System.EventHandler(this.bTeacher_Click);
            // 
            // bCourses
            // 
            this.bCourses.Location = new System.Drawing.Point(6, 19);
            this.bCourses.Name = "bCourses";
            this.bCourses.Size = new System.Drawing.Size(121, 54);
            this.bCourses.TabIndex = 0;
            this.bCourses.Text = "Управление курсами";
            this.bCourses.UseVisualStyleBackColor = true;
            this.bCourses.Click += new System.EventHandler(this.bCourses_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 167);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "Рабочее место Организации";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsolidation;
        private System.Windows.Forms.Button bTeacher;
        private System.Windows.Forms.Button bCourses;
        private System.Windows.Forms.Button bGetApplication;
        private System.Windows.Forms.Button btnPrice;
    }
}

