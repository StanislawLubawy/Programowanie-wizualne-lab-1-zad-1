using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplikacja_do_zamawiania_jedzenia
{
    public partial class Form3 : Form
    {
        public List<string> SelectedDeliveryOptions { get; private set; } = new();
        public event EventHandler<int>? DeliveryCostChanged;

        public Form3()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
            checkBox1.CheckedChanged += CheckBox_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox_CheckedChanged;
            checkBox3.CheckedChanged += CheckBox_CheckedChanged;
            checkBox4.CheckedChanged += CheckBox_CheckedChanged;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            SelectedDeliveryOptions.Clear();
            if (checkBox1.Checked) SelectedDeliveryOptions.Add(checkBox1.Text);
            if (checkBox2.Checked) SelectedDeliveryOptions.Add(checkBox2.Text);
            if (checkBox3.Checked) SelectedDeliveryOptions.Add(checkBox3.Text);
            if (checkBox4.Checked) SelectedDeliveryOptions.Add(checkBox4.Text);

            var total = CalculateSelectedCost();
            DeliveryCostChanged?.Invoke(this, total);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox_CheckedChanged(sender, e);
        }

        private void CheckBox_CheckedChanged(object? sender, EventArgs e)
        {
            SelectedDeliveryOptions.Clear();
            if (checkBox1.Checked) SelectedDeliveryOptions.Add(checkBox1.Text);
            if (checkBox2.Checked) SelectedDeliveryOptions.Add(checkBox2.Text);
            if (checkBox3.Checked) SelectedDeliveryOptions.Add(checkBox3.Text);
            if (checkBox4.Checked) SelectedDeliveryOptions.Add(checkBox4.Text);

            var total = CalculateSelectedCost();
            DeliveryCostChanged?.Invoke(this, total);
        }

        private int CalculateSelectedCost()
        {
            int sum = 0;
            foreach (var txt in SelectedDeliveryOptions)
            {
                var start = txt.LastIndexOf('(');
                var end = txt.LastIndexOf(')');
                if (start >= 0 && end > start)
                {
                    var inner = txt.Substring(start + 1, end - start - 1);
                    var digits = System.Text.RegularExpressions.Regex.Match(inner, "\\d+");
                    if (digits.Success && int.TryParse(digits.Value, out var v)) sum += v;
                }
            }
            return sum;
        }
    }
}
