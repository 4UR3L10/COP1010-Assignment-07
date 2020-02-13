using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_Software
{
    class StudentDBS
    {
        // List of students.
        List<Student> studentList = new List<Student>();

        // Adds an student to the list.
        public void addStudent(Student sObj)
        {
            studentList.Add(sObj);
        }

        // Will show all students once William Finish with the class. (Change it to public)
        private void showStudent()
        {
            foreach (Student std in studentList)
            {
                // MessageBox.Show(std.getID() + std.getName());
            }
        }

        // Method to search student.

        // Method to delete student.
    }
}
