using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburguer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "Insert into Itens(nome_produto,preco_unitario) values(@nome,@preco)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToInt32(txtPrecoProduto.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com Sucesso");



            }
            catch (Exception ex)
            {
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnFazerPedidoProduto_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }
    }
}
