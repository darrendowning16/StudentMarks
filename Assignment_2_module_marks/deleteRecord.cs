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
    public partial class deleteRecord : Form
    {

        public deleteRecord()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            txtStudentID.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 myForm = new Form1();
            myForm.ShowDialog();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student deleted successfully");
            this.Close();
        }

        private void deleteRecord_Load(object sender, EventArgs e)
        {
            txtStudentID.Text = ModuleData.student_id;
            txtMark.Text = ModuleData.mark;
        }
    }
}
