using LojadeJogo.Utils;
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

namespace LojadeJogo.Forms.Vendas
{
    public partial class ListaVendas : Form
    {
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        public ListaVendas()
        {
            InitializeComponent();
            this.lista("vendas", dataGridView1, "idVendas");
        }
        public void lista(string tabela, DataGridView dataGrid, string VarOrdenacao)
        {
            ConnectionFactory connection = new ConnectionFactory();
            try
            {
                DataSet conexaoDataset = new DataSet();
                connection.Conectar();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("" +
                    "SELECT V.descricao as Descricao, V.valor as Valor_Total, C.nome as Cliente, J.nome as Jogo_Vendido, F.nome as Funcionario " +
                    "FROM vendas as V " +
                    "LEFT JOIN clientes as C ON V.idClientes = C.idClientes " +
                    "LEFT JOIN funcionarios as F ON V.idFuncionarios = F.idFuncionarios " +
                    "LEFT JOIN jogos as J ON V.idJogos = J.idJogos", connection.getConnection());
                conexaoAdapter.Fill(conexaoDataset, tabela);
                dataGrid.DataSource = conexaoDataset;
                dataGrid.DataMember = tabela;
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                connection.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
