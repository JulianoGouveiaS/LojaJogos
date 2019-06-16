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
        DaoPlataformas daoPlat = new DaoPlataformas();
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
            daoPlat.preencheComboById(cbplat, obj.IdPlataforma);


            txtid.Text = obj.Id;
            txtnome.Text = obj.Nome;
            txtpreco.Text = obj.Preco;

        }

        public async void updateValor(string id, Label txtValor)
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetTaskAsync("Information/Jogos/" + id);

            Jogo obj = response.ResultAs<Jogo>();


            txtValor.Text = obj.Preco;

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
            MessageBox.Show("Sucesso");
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

        public async void preencheComboById(ComboBox cmb, string id)
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countJogos");

            //coloca o conteudo da referencia na variavel do tipo Counter_class que eu criei
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            //criei a var cnt e coloquei o valor de contagem que busquei do firebase
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Jogos/" + i);
                    Jogo obj2 = resp2.ResultAs<Jogo>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "nome";
            cmb.SelectedValue = id;
            cmb.Update();
        }

        public async void preencheCombo(ComboBox cmb)
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("plataforma");
            dt.Columns.Add("preco");

            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countJogos");

            //coloca o conteudo da referencia na variavel do tipo Counter_class que eu criei
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            //criei a var cnt e coloquei o valor de contagem que busquei do firebase
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Jogos/" + i);
                    Domain.Jogo obj2 = resp2.ResultAs<Domain.Jogo>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["plataforma"] = obj2.IdPlataforma;
                    row["preco"] = obj2.Preco;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "nome";
            cmb.Update();
        }
    }
}
