using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment_2_module_marks
{
    public partial class Form1 : Form
    {
        //Darren Downing - B00763295
        //Jack Campbell - B00763797
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // Starts the form in the center of the screen
        }

        Stats myStats = new Stats(); // Calls the Stats class

        private void Form1_Load(object sender, EventArgs e)
        {
            string studentRec;  // Declaring string variable

            StreamReader inputFile = File.OpenText("COM122.csv"); // Declaring a streamReader called inputfile and setting it to the data file

            while (!inputFile.EndOfStream)  // While not at the end of the file execute the while loop
            {
                studentRec = inputFile.ReadLine(); // Read all the lines in the file and store it to the lines variable
                ModuleData.studentInfo = studentRec.Split(',').ToList();  // Split all the lines after the ',' and coverts it to a list 
                ModuleData.studentNumber.Add(ModuleData.studentInfo[0]);  // Store the value of the first index of studentInfo to the variable studentNumber
                ModuleData.studentMarks.Add(ModuleData.studentInfo[1]);  // Store the value of the second index of studentInfo to the variable studentMark
                lstMarks.Items.Add(ModuleData.studentInfo[0].Trim() + " : " + ModuleData.studentInfo[1].Trim()); // Adds the student info together and trims any whitespace at the start or end and adds it to the listbox
            }
            inputFile.Close(); // closes the file
        }

        //Couldn't figure out the refreshlist method

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; // Makes sure the output label is empty

            addRecord myAddRecordForm = new addRecord(); // Opens a form called addRecord
            if (myAddRecordForm.ShowDialog() == DialogResult.OK) // If statement will run if the dialogResult is set to OK in the addRecord form
            {
                ModuleData.studentInfo.Add(myAddRecordForm.StudentID); // Adds the student ID to the studentInfo List
                ModuleData.studentInfo.Add(myAddRecordForm.Mark); // Adds the Mark to the studentInfo List
                ModuleData.studentMarks.Add(myAddRecordForm.Mark); // Adds the Mark to the studentMarks List
                lstMarks.Items.Add(myAddRecordForm.StudentID +" : "+ myAddRecordForm.Mark); // Adds the StudentID and Mark to the listbox
            }
        }

        private void btnEditMark_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; // makes sure the output label is empty

            if (lstMarks.SelectedIndex == -1) // if the user has not selected a student run the next piece of code 
            {
                MessageBox.Show("Please select a student"); //displays error
            }
            else
            {
                editMark edit = new editMark(); // open new form called edit
                edit.ShowDialog(); // shows the form
                lstMarks.Items[lstMarks.SelectedIndex] = editMark.data; // adds the data variable to the the users selected index
            }

        }
        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            string[] student_records_array; // Creating a string array to store all the s_rec data

            lblOutput.Text = ""; // Makes sure the output label is empty

            if (lstMarks.SelectedIndex == -1) // If no student is selected then code inside this IF statement will run
            {
                MessageBox.Show("Please select a student"); // Displays an error to the user
            }
            else // If the if statement passes then this code will run
            {
                ModuleData.student_record = lstMarks.SelectedItem.ToString(); // Stores the selected item into the s_rec variable
                student_records_array = ModuleData.student_record.Split(':'); // Stores all the data split at the : into the s_rec_arr Array
                ModuleData.student_id = student_records_array[0]; // Stores the first index of s_rec_arr into the s_id variable
                ModuleData.mark = student_records_array[1]; // Stores the second index of s_rec_arr into the s_mark variable
                deleteRecord myDeleteRecordForm = new deleteRecord(); // Opens a form called deleteRecord
                myDeleteRecordForm.ShowDialog(); // Shows the form
                lstMarks.Items.Remove(ModuleData.student_record); // Removes the record from the list that is held inside the s_rec variable
            }
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; // Makes sure the output label is empty

            double max; // declaring max as double 

            max = myStats.MaxMark(); // Sets max to maxmark class

            lblOutput.Text = "The maximum value is : " + max.ToString(); // Outputs Maxmark
        }
        private void btnMin_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; // Makes sure the output label is empty

            double min; // declaring max as double

            min = myStats.MinMark(); // Sets max to maxmark class

            lblOutput.Text = "The minimum value is : " + min.ToString(); // Outputs Minmark
        }
        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblOutput.Text = ""; // Makes sure the output label is empty

            double average; // Declaring average variable as double

            average = myStats.AverageMark(); // Getting the averageMark method from the myStats class and assigning the returned value to the average variable

            lblOutput.Text = $"The average is: {average.ToString()}"; // Outputting the average variable
        }
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if(lstMarks.Items.Count > 0) // Checks if there is marks inside the listbox
            {
                using(TextWriter outputfile = new StreamWriter("COM122.csv")) // Writes the data to the file
                {
                    foreach(string data in lstMarks.Items) // Goes through all the items in the list 
                    {
                        outputfile.WriteLine(string.Join(",", data.Split(':'))); //Splits data at the : and turns it into an array from a string and then rejoins both of them converting it back to a string 
                    }
                    MessageBox.Show("Student Information inserted successfully"); // Displays a message to the user
                }
            }
            else
            {
                MessageBox.Show("No marks to save"); //Displays an error
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the program
        }
    }
}
