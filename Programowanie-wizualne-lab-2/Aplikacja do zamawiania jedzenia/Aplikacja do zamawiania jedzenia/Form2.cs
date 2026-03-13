using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplikacja_do_zamawiania_jedzenia
{
    public partial class Form2 : Form
    {
        private List<string> _availableProducts = new();
        public List<string> SelectedProducts { get; private set; } = new();

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(List<string> products) : this()
        {
            if (products != null)
            {
                _availableProducts = new List<string>(products);
                listBox1.Items.Clear();
                foreach (var p in _availableProducts)
                    listBox1.Items.Add(p);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectedProducts.Clear();
            foreach (var it in listBox1.SelectedItems)
            {
                if (it is string s)
                    SelectedProducts.Add(s);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
