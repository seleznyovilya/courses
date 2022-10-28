using System;
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
    public partial class View_Consolidation : Form
    {
        Model db = new Model();
        Consolidation consolidation = new Consolidation();
        public View_Consolidation()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            consolidation.start = dBegin.Text;
            consolidation.end = dEnd.Text;
           
            consolidation.id_course = Convert.ToInt32(LBname_of_course.SelectedValue);
            consolidation.id_teacher = Convert.ToInt32(LBteacher.SelectedValue);
            
            

            var success = db.AddConsolidation(consolidation);

            tvConsolidation.DataSource = db.GetAllConsolidation();

            if (success)
            {
                MessageBox.Show("Course has been added successfully");
            }
            else
                MessageBox.Show("Ошибка");
        }

        private void ConsolidationView_Load(object sender, EventArgs e)
        {
            
            LBname_of_course.DataSource = db.GetAllCourse();
            LBname_of_course.DisplayMember = "name";
            LBname_of_course.ValueMember = "id";
            LBteacher.DataSource = db.GetAllTeacher();
            LBteacher.DisplayMember = "fio";
            LBteacher.ValueMember = "id";
            tvConsolidation.DataSource = db.GetAllConsolidation();
        }
    }
}
