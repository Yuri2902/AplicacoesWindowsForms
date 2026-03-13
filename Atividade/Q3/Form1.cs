namespace Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Km, preco;
            Km= Convert.ToDouble(txtDistancia.Text);
            if (Km<=200)
            {
                preco = Km * 0.50;
            }
            else 
            {
                preco  = Km * 0.45;
            }
             lbResultado.Text = preco.ToString();
        }
    }
}
