namespace Aplikacja_do_zamawiania_jedzenia
{
    public partial class Form1 : Form
    {
        private List<string> _products = new() { "Pizza", "Burger", "Sałatka", "Sushi", "Frytki" };
        private List<string> _cart = new();
        private int _deliveryCost = 0;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            listView1.View = View.List;
            listView1.Items.Clear();
            UpdatePriceLabel();
        }

        private void UpdatePriceLabel()
        {
            var itemsTotal = _cart.Count * 10;
            label1.Text = $"Cena: {itemsTotal} PLN";
            label2.Text = $"Cena opcji dostawy: {_deliveryCost} PLN";
            label3.Text = $"Cena razem: {itemsTotal + _deliveryCost} PLN";
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            var f2 = new Form2(_products);
            if (f2.ShowDialog() == DialogResult.OK)
            {
                foreach (var s in f2.SelectedProducts)
                {
                    _cart.Add(s);
                    listView1.Items.Add(new ListViewItem(s));
                }
                UpdatePriceLabel();
            }
        }

        private void Button2_Click(object? sender, EventArgs e)
        {
            var f3 = new Form3();
            EventHandler<int> handler = (s, cost) =>
            {
                _deliveryCost = cost;
                UpdatePriceLabel();
            };
            f3.DeliveryCostChanged += handler;
            if (f3.ShowDialog() == DialogResult.OK)
            {
                var opts = f3.SelectedDeliveryOptions;
                var newDelivery = 0;
                foreach (var o in opts)
                {
                    var cost = ParseCostFromOption(o);
                    newDelivery += cost;
                }
                _deliveryCost = newDelivery;
                UpdatePriceLabel();
                if (opts.Count > 0)
                {
                    MessageBox.Show("Wybrane opcje dostawy: " + string.Join(", ", opts));
                }
            }
            f3.DeliveryCostChanged -= handler;
        }

        private int ParseCostFromOption(string option)
        {
            if (string.IsNullOrEmpty(option)) return 0;
            var start = option.LastIndexOf('(');
            var end = option.LastIndexOf(')');
            if (start >= 0 && end > start)
            {
                var inner = option.Substring(start + 1, end - start - 1);
                var m = System.Text.RegularExpressions.Regex.Match(inner, "\\d+");
                if (m.Success && int.TryParse(m.Value, out var val)) return val;
            }
            return 0;
        }

        private void Button3_Click(object? sender, EventArgs e)
        {
            var f4 = new Form4();
            if (f4.ShowDialog() == DialogResult.OK)
            {
                var payment = f4.SelectedPayment;
                MessageBox.Show("Wybrana metoda płatności: " + payment);
                label4.Text = $"Wybrana opcja zapłaty: {payment}";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
