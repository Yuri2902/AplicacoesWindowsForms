namespace Q5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Cadastrado com Sucesso");
                return;
            }
            Pessoa novoUsuario = new Pessoa();
            novoUsuario.Nome = txtNome.Text;
            novoUsuario.Idade = txtIdade.Text;
            MessageBox.Show("Usúario Cadastrado com sucesso");
         

        }
    }
}
