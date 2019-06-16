using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Forms.Clientes
{
    public partial class ListaCliente : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();
        public ListaCliente()
        {
            InitializeComponent();
            string[] colunas = { "id", "nome", "telefone" };
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

            //parametro pro while
            i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countClientes");

            //coloca o conteudo da referencia na variavel do tipo Counter_class que eu criei
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            //criei a var cnt e coloquei o valor de contagem que busquei do firebase
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                //while ate rodar todos os objetos, pois cnt vai estar representando quantos cadastros ja existem
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Clientes/" + i);
                    Cliente obj2 = resp2.ResultAs<Cliente>();

                    DataRow row = dt.NewRow();

                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["telefone"] = obj2.Telefone;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            /*
            ConnectionFactory connection = new ConnectionFactory();
            try
            {
                DataSet conexaoDataset = new DataSet();
                connection.Conectar();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM " + tabela + " ORDER BY " + VarOrdenacao, connection.getConnection());
                conexaoAdapter.Fill(conexaoDataset, tabela);
                dataGrid.DataSource = conexaoDataset;
                dataGrid.DataMember = tabela;
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                connection.Close();
            }*/
        }
    }
}
