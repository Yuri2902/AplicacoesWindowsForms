namespace Q4
{
    public partial class lstTabuada : Form
    {
        public lstTabuada()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(txtNumero.Text);
            for (double i = 1; i <= 10; ++i)
            {
                double r = n * i;
                listBox1.Items.Add($"{n} x {i} = {r}");
                txtNumero.Clear();
                txtNumero.Focus();
            }

        }
    }
}
