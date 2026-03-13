using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplikacja_do_zamawiania_jedzenia
{
    public partial class Form4 : Form
    {
        public string SelectedPayment { get; private set; } = string.Empty;

        public Form4()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (radioButton1.Checked) SelectedPayment = radioButton1.Text;
            else if (radioButton2.Checked) SelectedPayment = radioButton2.Text;
            else if (radioButton3.Checked) SelectedPayment = radioButton3.Text;
            else if (radioButton4.Checked) SelectedPayment = radioButton4.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
