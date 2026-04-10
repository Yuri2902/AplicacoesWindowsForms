using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;
namespace Hamburguer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "Insert into Clientes(nome,cpf) values(@nome,@cpf)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com Sucesso");

                string sqlMostrar = "SELECT * FROM Clientes";

                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();//tabela virtual, ele puxa as informações

                adp.Fill(dt);
                dgvClientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();

        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
