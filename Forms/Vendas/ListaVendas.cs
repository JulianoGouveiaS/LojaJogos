using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Forms.Firebase;
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
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        public ListaVendas()
        {
            InitializeComponent();
            string[] colunas = { "id", "descricao", "valor", "cliente", "jogo", "funcionario" };
            this.lista(dataGridView1, colunas);
        }
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async void lista(DataGridView dataGrid, string[] colunas)
        {
            this.client = connection.getClient();
            DataTable dt = new DataTable();
            int i = 0;
            for (i = 0; i < colunas.Count(); i++)
            {
                dt.Columns.Add(colunas[i]);
            }

            dataGrid.DataSource = dt;

            i = 0;

            dt.Rows.Clear();

            FirebaseResponse resp1 = await client.GetAsync("Counter/countVendas");

            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            int cnt = Convert.ToInt32(obj1.cnt);

            for (i = 0; i <= cnt; i++)
            {
                try
                {

                    FirebaseResponse resp2 = await client.GetAsync("Information/Vendas/" + i);
                    Domain.Venda obj2 = resp2.ResultAs<Domain.Venda>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id.ToString();
                    row["valor"] = obj2.Valor.ToString();
                    row["descricao"] = obj2.Descricao.ToString();

                    FirebaseResponse response = await client.GetAsync("Information/Jogos/" + obj2.IdJogo.ToString());
                    Domain.Jogo jogoEncontrado = response.ResultAs<Domain.Jogo>();

                    row["jogo"] = jogoEncontrado.Nome;

                    FirebaseResponse response2 = await client.GetAsync("Information/Clientes/" + obj2.IdCliente.ToString());
                    Domain.Cliente clienteEncontrado = response.ResultAs<Domain.Cliente>();

                    row["cliente"] = clienteEncontrado.Nome;

                    FirebaseResponse response3 = await client.GetAsync("Information/Funcionarios/" + obj2.IdFuncionario.ToString());
                    Funcionario funcEncontrado = response.ResultAs<Funcionario>();

                    row["funcionario"] = funcEncontrado.Nome;
                    
                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
