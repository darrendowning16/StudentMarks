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
    public partial class addRecord : Form
    {
        public addRecord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Starts the form in the center of the screen
            txtStudentID.Focus(); // Focuses on the student ID text box
        }

        // Declaring a backing field string for StudentID
        private string _StudentID;

        // Creating a StudentID string 
        public string StudentID
        {
            // Gets the result from _StudentID and stores it in StudentID
            get
            {
                return _StudentID; 
            }
        }

        // Declaring a backing field string for Mark
        private string _Mark;

        // Creating a Mark string 
        public string Mark 
        {
            // Gets the result from _Mark and stores it in Mark
            get
            {
                return _Mark;
            }
        }
        
       
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtStudentID.TextLength == 6) // Checks if the users input is 6 characters in length
            {
                // Declaring variable
                int mark;

                if (int.TryParse(txtMark.Text, out mark)) // Checks if the users input is a valid integer
                {
                    if (mark >= 0 && mark <= 100) // Checks if the users input is between 0 and 100
                    {
                        _StudentID = txtStudentID.Text; // Sets the input from studentID text box to the _StudentID (BackField)
                        _Mark = mark.ToString(); // Sets the input from Mark text box to the _Mark (BackField)
                        MessageBox.Show("Record added Successfully"); // Displays a message to the user
                        DialogResult = DialogResult.OK; // Sets the diaglog result to OK
                    }
                    else
                    {
                        MessageBox.Show("Mark must be between 0 - 100"); // Displays an error to the user
                    }
                }
                else
                {
                    MessageBox.Show("Mark must be a whole number"); // Displays an error to the user
                }
            }
            else
            {
                MessageBox.Show("Student Number must be 6 characters"); // Displays an error to the user
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the form
            Form1 myForm = new Form1(); // Opens a form called Form1
        }
    }
}
