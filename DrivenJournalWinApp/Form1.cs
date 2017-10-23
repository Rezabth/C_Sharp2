﻿using DriverJournalLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivenJournalWinApp
{
    public partial class Form1 : Form
    {
        private DriverJournal driverJounal = new DriverJournal();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = dateTimePicker1.Value.Year;
            int month = dateTimePicker1.Value.Month;
            decimal miles = numericUpDown1.Value;
            string description = textBox1.Text;
            driverJounal.AddEntry(year, month, miles, description);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var year = dateTimePicker2.Value.Year;
            var month = dateTimePicker2.Value.Month;
            label1.Text = driverJounal.MilesDriven(year, month).ToString();
        }
    }
}
