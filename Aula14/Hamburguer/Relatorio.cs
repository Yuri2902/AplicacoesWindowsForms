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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            string sql = "SELECT  Clientes.nome, Clientes.cpf, Itens.nome_produto, Compras.quantidade From Compras INNER JOIN Clientes ON Compras.id_cliente = Cliente.id_cliente INNER JOIN Itens ON Compras.id_item = Itens.id_item";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRelatorio.DataSource = dt;

        }

        private void lbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
