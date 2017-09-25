using ExamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamWindowsFormsApp
{
    public partial class Form1 : Form
    {
        Exam myExam = new Exam("");


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            Student nyStudent = new Student(textBoxStudent.Text);
            myExam.Assign(nyStudent);
            myExam.Grade(nyStudent, comboBoxGrade.SelectedItem.ToString());


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {



        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var gradeCountDictionary = myExam.GenerateStatistics();
            var IGCounter = gradeCountDictionary["IG"];
            label1.Text = $"IG: {IGCounter}";

            var GCounter = gradeCountDictionary["G"];
            label2.Text = $"G: {GCounter}";

            var VGCounter = gradeCountDictionary["VG"];
            label3.Text = $"VG: {VGCounter}";
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
