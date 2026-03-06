using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calculation;
namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Calculate cal = new Calculate();

        private bool TryGetInputs(out double a, out double b)
        {
            a = 0; b = 0;
            if (!double.TryParse(textBox1.Text?.Trim(), out a))
            {
                MessageBox.Show("Nieprawid³owa pierwsza liczba", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!double.TryParse(textBox2.Text?.Trim(), out b))
            {
                MessageBox.Show("Nieprawid³owa druga liczba", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;
            double result = cal.Add(a, b);
            lblWynik.Text = result.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;
            double result = cal.Subtract(a, b);
            lblWynik.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;
            double result = cal.Multiply(a, b);
            lblWynik.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!TryGetInputs(out double a, out double b))
                return;
            try
            {
                double result = cal.Divide(a, b);
                lblWynik.Text = result.ToString();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWynik.Text = "---";
            }
        }
    }
}
