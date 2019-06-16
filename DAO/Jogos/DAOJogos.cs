using LojadeJogo.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.DAO.Plataformas;

namespace LojadeJogo.DAO.Jogos
{
    class DAOJogos
    {
        ConnectionFactory connection = new ConnectionFactory();
        DaoPlataformas dao = new DaoPlataformas();
        IFirebaseClient client;

        public async void Salvar(Jogo jogo)
        {
            try
            {
                this.client = connection.getClient();

            FirebaseResponse resp = await client.GetTaskAsync("Counter/countJogos");

            Counter_class get = resp.ResultAs<Counter_class>();

            var jogo2 = new Jogo
            {
                Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                Nome = jogo.Nome,
                IdPlataforma = jogo.IdPlataforma,
                Preco = jogo.Preco
            };

            SetResponse response = await client.SetTaskAsync("Information/Jogos/" + jogo2.Id, jogo2);

            Jogo result = response.ResultAs<Jogo>();

            MessageBox.Show(result.Nome + " enviado com sucesso");


            var obj = new Counter_class
            {
                cnt = jogo2.Id
            };

            SetResponse response1 = await client.SetTaskAsync("Counter/countJogos", obj);
        }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo o inesrt!!");
            }
            
        }
     
        public async void BuscarPorId(string id, TextBox txtid, TextBox txtnome, ComboBox cbplat, TextBox txtpreco)
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetTaskAsync("Information/Jogos/" + id);

            Jogo obj = response.ResultAs<Jogo>();

        //    int idEscolhido = int.Parse(cmbPlataformas.SelectedValue.ToString());
          //  Plataforma plataformaEscolhida = new Plataforma();
            //plataformaEscolhida = dao.buscarPorId(idEscolhido);


            txtid.Text = obj.Id;
            txtnome.Text = obj.Nome;
            txtpreco.Text = obj.Preco;

        }


        public async void Excluir(string id)
        {
            try
            {
                this.client = connection.getClient();
                FirebaseResponse response = await client.DeleteTaskAsync("Information/Jogos/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                FirebaseResponse resp = await client.GetTaskAsync("Counter/countJogos");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetTaskAsync("Counter/countJogos", obj);

            }




        }

        public async void Editar(Jogo jogo)
        {

            FirebaseResponse resp = await client.GetTaskAsync("Information/Jogos/" + jogo.Id);

            Jogo get = resp.ResultAs<Jogo>();
            var obj = new Jogo
            {
                Id = jogo.Id,
                Nome = jogo.Nome,
                Preco = jogo.Preco,
                IdPlataforma = jogo.IdPlataforma
            };
            SetResponse response1 = await client.SetTaskAsync("Information/Jogos/" + jogo.Id, obj);
        }

        public DataTable RightJoinLista()
        {
            DataTable tabela = new DataTable();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                connection.Conectar();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "SELECT j.nome AS Jogo, j.preco AS Preco, p.nome AS Plataforma FROM jogos j INNER JOIN plataformas p ON j.idPlataformas = p.idPlataformas";
                tabela.Load(cmd.ExecuteReader());
                // MessageBox.Show("Conexao feita com sucesso");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {

                connection.Close();
            }

            return tabela;

        }


    }
}
