using SE_user_control_lab.User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace SE_user_control_lab
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
           
            StudentControl studentControl = new StudentControl();
            studentControl.Dock = DockStyle.Top;
            studentControl.AddStudentEvent += AddStudent;
            studentControl.SearchStudentEvent += SearchStudent;
            this.Controls.Add(studentControl);
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Grade", "Grade");

        }
      
        private void AddStudent(string name, int age, string grade)
        {
            students.Add(new Student { Name = name, Age = age, Grade = grade });
            UpdateGrid(students);
        }

        private void SearchStudent(string name)
        {
            var filtered = students.Where(s => s.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();
            UpdateGrid(filtered);
        }
        private void UpdateGrid(List<Student> data)
        {
            dataGridView1.Rows.Clear();
            foreach (var student in data)
            {
                dataGridView1.Rows.Add(student.Name, student.Age, student.Grade);
            }
        }

        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }
    }
}
