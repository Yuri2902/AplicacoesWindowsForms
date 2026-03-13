namespace Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double D,X, R;
            D =Convert.ToDouble(txtCotacao.Text);
            X = Convert.ToDouble(txtDolares.Text);
            R = D * X;
            lblResultado.Text = R.ToString();
        }
    }
}
