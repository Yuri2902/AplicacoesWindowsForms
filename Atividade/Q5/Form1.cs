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
          Pessoa Cadasdastro = new Pessoa();

            Cadasdastro.Nome = txtNome.Text;
            Cadasdastro.Idade = txtIdade.Text;
            Repositorio.ListaPessoas.Add(Cadasdastro);
            listBox1.Items.Add($"{Cadasdastro.Nome} {txtIdade.Text}");  
        }
    }
}
