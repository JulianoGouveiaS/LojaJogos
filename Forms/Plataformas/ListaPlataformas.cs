using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
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

namespace LojadeJogo.Forms.Plataformas
{
    public partial class ListaPlataformas : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        public ListaPlataformas()
        {
            InitializeComponent();
            string[] colunas = { "id", "nome" };
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
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countPlataformas");

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

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Plataformas/" + i);
                    Plataforma obj2 = resp2.ResultAs<Plataforma>();

                    DataRow row = dt.NewRow();

                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
    }
}
