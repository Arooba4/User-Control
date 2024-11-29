using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE_user_control_lab.User_Control
{
    public partial class StudentControl : UserControl
    {

        public event Action<string, int, string> AddStudentEvent;
        public event Action<string> SearchStudentEvent;
        public StudentControl()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string grade = txtGrade.Text;

            AddStudentEvent?.Invoke(name, age, grade);

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtGrade.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }
          
            txtName.Clear();
            txtAge.Clear();
            txtGrade.Clear();

         

          
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchName = txtSearchName.Text;
            SearchStudentEvent?.Invoke(searchName);

            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                SearchStudentEvent?.Invoke(txtName.Text);
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
            txtSearchName.Clear();
         
        }
    }
}
