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
    internal partial class DeleteStudent : Form
    {
        // Data Field.
        StudentDBS stdDBS;

        // Constructor.
        public DeleteStudent(StudentDBS studentDBS)
        {
            InitializeComponent();
            stdDBS = studentDBS;
        }
    }
}
