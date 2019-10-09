using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Assignment_2_module_marks
{
    class Stats
    {
        public int MaxMark() // declaring public method
        {
            int highest = int.Parse(ModuleData.studentMarks[0]); // storing highest as an int var and checking index of studentmark then converting it
            for (int index = 1; index < ModuleData.studentMarks.Count; index++) // creating for loop, setting index to 1, checking if student mark is less than index and incrementing it by 1
            {
                if (int.Parse(ModuleData.studentMarks[index]) > highest) // checking index of student mark and seeing if it is greater than the highest var
                {
                    highest = int.Parse(ModuleData.studentMarks[index]); // storing highest var
                }
            }
            return highest; // returns highest value
        }
        public int MinMark() // declaring public method
        {
            int lowest = int.Parse(ModuleData.studentMarks[0]); // storing lowest as an int var and checking index of studentmark then converting it
            for (int index = 1; index < ModuleData.studentMarks.Count; index++) // creating for loop, setting index to 1, checking if student mark is less than index and incrementing it by 1
            {
                if (int.Parse(ModuleData.studentMarks[index]) < lowest) // checking index of student mark and seeing if it is less than the lowest var
                {
                    lowest = int.Parse(ModuleData.studentMarks[index]); // storing lowest value
                }
            }
            return lowest; //returns lowest value

        }
        public double AverageMark() // Creating a public method called AverageMark
        {
            int total = 0; // Declaring variable called total and storing it as 0

            for (int i = 0; i < ModuleData.studentMarks.Count; i++) // Creating for loop and runs the code inside every time the condition is true
            {
                int value = 0; // Declaring a variable called value
                value = int.Parse(ModuleData.studentMarks[i]); // Setting value = to the value of i
                total += value; // Adding the value to total 
            }
            return total / ModuleData.studentMarks.Count; // Return the total and divide by the amount of items in the studentmarks list
        }
    }
}
