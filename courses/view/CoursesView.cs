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
    

    public partial class CoursesView : Form
    {
        Course course = new Course();
        Database db = new Database();
        public CoursesView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CoursesView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.GetAllCourse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            course.name = tbNameCourse.Text;
            course.type = tbTypeCourse.Text;
            course.count = Convert.ToInt32(tbCountStudyDays.Text);

            
            var success = db.AddCourse(course);
            dataGridView1.DataSource = db.GetAllCourse();
            if (success)
            {
                MessageBox.Show("Course has been added successfully");
            }
            else
                MessageBox.Show("Ошибка");
        }
    }
}
