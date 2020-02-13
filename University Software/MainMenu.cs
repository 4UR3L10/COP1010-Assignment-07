using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Software
{
    public partial class MainMenu : Form
    {

        StudentDBS stdDBS = new StudentDBS();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void UpdateStudentButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            DeleteStudent dso = new DeleteStudent(stdDBS);
            dso.ShowDialog();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudent asfo = new AddStudent(stdDBS);
            asfo.ShowDialog();
        }
    }
}
