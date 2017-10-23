using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
    public partial class EmployeeInformation : Form
    {
        public EmployeeInformation()
        {
            InitializeComponent();
        }

        Employee anEmployee = new Employee();


        private void buttonSave_Click(object sender, EventArgs e)
        {
              anEmployee.id = textBoxId.Text;
              anEmployee. name = textBoxName.Text;
              anEmployee. salary = textBoxSalary.Text;
              textBoxId.Clear();
              textBoxName.Clear();
              textBoxSalary.Clear();
              MessageBox.Show("Employee Information:" + Environment.NewLine + "id:" + anEmployee. id + Environment.NewLine + "Name:" + anEmployee. name + Environment.NewLine + "Salary:" + anEmployee.salary );



        }

        private void buttonRetrive_Click(object sender, EventArgs e)
        {
            textBoxId.Text = anEmployee.id;
            textBoxName.Text = anEmployee.name;
            textBoxSalary.Text = anEmployee.salary;
        }

        private void EmployeeInformation_Load(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
