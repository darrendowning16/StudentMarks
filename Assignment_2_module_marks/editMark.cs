using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_module_marks
{
    public partial class editMark : Form
    {
        public editMark()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtStudentID.Focus(); // focuses on txts studentID textbox
        }

        public static string data; // sets data as a public string 
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string student_ID; // settings string var
            int Student_Mark; // setting int var

            student_ID = txtStudentID.Text; // storing the users input as student_ID

            if(int.TryParse(txtMark.Text, out Student_Mark)) // checks if the txtmark is an intger and stores it in the student_mark variable
            {
                if (Student_Mark > 0 && Student_Mark <= 100) // checks if the student_mark is between 0 and 100
                {
                    if (student_ID.Length == 6) // checks if the length of the student id is equal to 6, if it is the code in this if statement will run
                    {
                        data = student_ID + " : " + Student_Mark; // storing student_ID : student_mark as data
                        this.Close(); // closing form
                    }
                    else 
                    {
                        MessageBox.Show("Student must be 6 characters"); // displays error 
                    }
                }
                else
                {
                    MessageBox.Show("Mark must be a valid integer between 0 and 100"); // displays error
                }
            }
            else
            {
                MessageBox.Show("Mark must be a valid integer"); // displays error
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); // hides form
            Form1 myForm = new Form1(); // opens new form
            myForm.ShowDialog(); // shows the form
        }
    }
}
