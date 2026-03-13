namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double C, F;
            C = Convert.ToDouble(txtCelsius.Text);

            F = (C * 9 / 5) + 32;

            lblResultado.Text = F.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
