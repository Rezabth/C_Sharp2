using PracticeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        private Personinformation personobj = new Personinformation();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var dateofbirth = dateTimePicker.Value.ToString("yyyy-MM-dd");
            var name = textBoxName.Text;
            var telefonno = textBoxPhone.Text;


            personobj.EnterDetails(dateofbirth, name, telefonno);
            labelResult.Text = personobj.Greeting;

            System.IO.File.WriteAllText(@"C:\Users\Studerande\Documents\Visual Studio 2017\Projects\ConsoleApp2\PracticeAPP\TextFile1.txt", personobj.Greeting);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Studerande\Documents\Visual Studio 2017\Projects\ConsoleApp2\PracticeAPP\TextFile1.txt");


            foreach (string line in lines)
            {
                
                MessageBox.Show("\t" + line);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var actualdateofbirth = int.Parse(dateTimePicker.Value.ToString("yyyyMMdd"));
            int nowdob = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int age = (nowdob - actualdateofbirth) / 10000;
            var name = textBoxName.Text;
            MessageBox.Show($"{ name} är {age} år gammal");
        }
    }
}