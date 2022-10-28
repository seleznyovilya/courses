using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courses
{
    

    public partial class View_Courses : Form
    {
        Course course = new Course();
        Model db = new Model();
        public View_Courses()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CoursesView_Load(object sender, EventArgs e)
        {
            tvCourses.DataSource = db.GetAllCourse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course.name = LBname_of_course.Text;
            course.type = tbTypeCourse.Text;
            course.count = Convert.ToInt32(LBamount_day_of_course.Text);

            
            var success = db.AddCourse(course);
            tvCourses.DataSource = db.GetAllCourse();
            if (success)
            {
                MessageBox.Show("Course has been added successfully");
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
