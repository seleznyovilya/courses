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

        private void bCourses_Click(object sender, EventArgs e)
        {
            View_Courses coursesView = new View_Courses();
            coursesView.Show();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            View_Price priceView = new View_Price();
            priceView.Show();
        }

        private void bTeacher_Click(object sender, EventArgs e)
        {
            View_Teachers teachersView = new View_Teachers();
            teachersView.Show();
        }



        private void btnConsolidation_Click(object sender, EventArgs e)
        {
            View_Consolidation consolidationView = new View_Consolidation();
            consolidationView.Show();
        }

        private void bSentApplication_Click(object sender, EventArgs e)
        {
            View_Application sendApplication = new View_Application();
            sendApplication.Show();
        }

        private void bGetApplication_Click(object sender, EventArgs e)
        {
            View_Application sendApplication = new View_Application();
            sendApplication.Show();
        }
    }
}
