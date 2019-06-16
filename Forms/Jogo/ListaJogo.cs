using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Jogos;
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
using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;

namespace LojadeJogo.Forms.Jogo
{
    public partial class ListaJogo : Form
    {
        Utilitarios utilitarios = new Utilitarios();
        DAOClientes daoClientes = new DAOClientes();
        DAOJogos daoJ = new DAOJogos();
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();
        DaoPlataformas daoPlat = new DaoPlataformas();

        public ListaJogo()
        {
            InitializeComponent();

            // utilitarios.lista("jogos", dataGridView_jogos, "idJogos");

            //   dataGridView_jogos.DataSource = daoJ.RightJoinLista();

            string[] colunas = { "id", "nome", "plataforma", "preco" };
            this.lista(dataGridView1, colunas);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_jogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countJogos");

            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            int cnt = Convert.ToInt32(obj1.cnt);

            for (i = 0; i <= cnt; i++)
            {
                try
                {

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Jogos/" + i);
                    Domain.Jogo obj2 = resp2.ResultAs<Domain.Jogo>();

                    DataRow row = dt.NewRow();
                  // MessageBox.Show(obj2.Id + " " + obj2.IdPlataforma + " " + obj2.Nome + " " + obj2.Preco);
                    row["id"] = obj2.Id.ToString();
                    row["nome"] = obj2.Nome.ToString();
                    
                    FirebaseResponse response = await client.GetTaskAsync("Information/Plataformas/" + obj2.IdPlataforma.ToString());

                    Plataforma plataformaEncontrada = response.ResultAs<Plataforma>();

                    row["plataforma"] = plataformaEncontrada.Nome;
                    row["preco"] = obj2.Preco.ToString();


                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
