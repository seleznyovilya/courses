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
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffView staff = new StaffView();
            staff.Show();
        }

        private void bCourses_Click(object sender, EventArgs e)
        {
            CoursesView coursesView = new CoursesView();
            coursesView.Show();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            PriceView priceView = new PriceView();
            priceView.Show();
        }

        private void bTeacher_Click(object sender, EventArgs e)
        {
            TeachersView teachersView = new TeachersView();
            teachersView.Show();
        }



        private void btnConsolidation_Click(object sender, EventArgs e)
        {
            ConsolidationView consolidationView = new ConsolidationView();
            consolidationView.Show();
        }

        private void bSentApplication_Click(object sender, EventArgs e)
        {
            ApplicationView sendApplication = new ApplicationView();
            sendApplication.Show();
        }

        private void bGetApplication_Click(object sender, EventArgs e)
        {
            ApplicationView sendApplication = new ApplicationView();
            sendApplication.Show();
        }
    }
}
