﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courses
{
    public partial class ConsolidationView : Form
    {
        Database db = new Database();
        Consolidation consolidation = new Consolidation();
        public ConsolidationView()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            consolidation.start = dBegin.Text;
            consolidation.end = dEnd.Text;
           
            consolidation.id_course = Convert.ToInt32(cbCourse.SelectedValue);
            consolidation.id_teacher = Convert.ToInt32(cbTeacher.SelectedValue);
            
            

            var success = db.AddConsolidation(consolidation);

            dataGridView1.DataSource = db.GetAllConsolidation();

            if (success)
            {
                MessageBox.Show("Course has been added successfully");
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void ConsolidationView_Load(object sender, EventArgs e)
        {
            
            cbCourse.DataSource = db.GetAllCourse();
            cbCourse.DisplayMember = "name";
            cbCourse.ValueMember = "id";
            cbTeacher.DataSource = db.GetAllTeacher();
            cbTeacher.DisplayMember = "fio";
            cbTeacher.ValueMember = "id";
            dataGridView1.DataSource = db.GetAllConsolidation();
        }
    }
}
