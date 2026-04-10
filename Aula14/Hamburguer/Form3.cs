using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hamburguer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                // load ele carrega os códigos
                Conexao conexao = new Conexao();
                MySqlConnection conn = conexao.Conectar();

                conn.Open();

                string sql = "SELECT * FROM Clientes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbClientes.DataSource = dt;
                cbClientes.DisplayMember = "nome";
                cbClientes.ValueMember = "id_cliente";

                string sqlItens = "SELECT * FROM Itens";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlItens, conn);

                DataTable dt2 = new DataTable();
                adp.Fill(dt2);

                cbItens.DataSource = dt2;
                cbItens.DisplayMember = "nome_produto";
                cbItens.ValueMember = "id_item";
            }
            catch (Exception ex)
            {

            }

        }

        private void
            btnSalvarPeido_Click(object sender, EventArgs e)
        {
            int idClient = Convert.ToInt32(cbClientes.SelectedValue);
            int idItem = Convert.ToInt32(cbItens.SelectedValue);
            int quantidade = Convert.ToInt32(numQuantidade.Value);
            Conexao conexao = new Conexao();
            MySqlConnection conn = conexao.Conectar();
            try
            {
                conn.Open();
                string sql = "Insert into Compras (id_cliente, id_item, quantidade Values (@cliente, @item @qtd)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("cliente", idClient);
                cmd.Parameters.AddWithValue("item", idItem);
                cmd.Parameters.AddWithValue("qtd", quantidade);

                MessageBox.Show("Compra cadastrada");
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            new Relatorio();

        }
    }
}
