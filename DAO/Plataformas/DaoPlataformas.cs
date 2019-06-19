using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Plataformas
{
    public class DaoPlataformas
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;


        public async void salvar(Plataforma plataforma)
        {
            try { 

            this.client = connection.getClient();

            FirebaseResponse resp = await client.GetAsync("Counter/countPlataformas");

            Counter_class get = resp.ResultAs<Counter_class>();

            var plataforma2 = new Plataforma
            {
                id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                Nome = plataforma.Nome,
            };

            SetResponse response = await client.SetAsync("Information/Plataformas/" + plataforma2.Id, plataforma2);

            Plataforma result = response.ResultAs<Plataforma>();

            MessageBox.Show(result.Nome + " enviado com sucesso");


            var obj = new Counter_class
            {
                cnt = plataforma2.Id
            };

            SetResponse response1 = await client.SetAsync("Counter/countPlataformas", obj);
        }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo o inesrt!!");
            }
            finally
            {

            }
        }

        public async void Excluir(string id)
        {
            try
            {
                this.client = connection.getClient();
                FirebaseResponse response = await client.DeleteAsync("Information/Plataformas/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                FirebaseResponse resp = await client.GetAsync("Counter/countPlataformas");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetAsync("Counter/countPlataformas", obj);

            }

        }

        public async void Editar(Plataforma plataforma)
        {
            FirebaseResponse resp = await client.GetAsync("Information/Plataformas/" + plataforma.Id);

            Plataforma get = resp.ResultAs<Plataforma>();
            var obj = new Plataforma
            {
                Id = plataforma.Id,
                Nome = plataforma.Nome
            };
            SetResponse response1 = await client.SetAsync("Information/Plataformas/" + plataforma.Id, obj);

        }

        public async void buscarPorId(string id, TextBox txtid, TextBox txtnome)
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetAsync("Information/Plataformas/" + id);

            Plataforma obj = response.ResultAs<Plataforma>();


            txtid.Text = obj.Id;
            txtnome.Text = obj.Nome;

        }

        public async void preencheCombo(ComboBox cmb)
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
            FirebaseResponse resp1 = await client.GetAsync("Counter/countPlataformas");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Plataformas/" + i);
                    Plataforma obj2 = resp2.ResultAs<Plataforma>();

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
            cmb.Update();
        }


        public async void preencheComboById(ComboBox cmbPlataformas, string id)
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
            FirebaseResponse resp1 = await client.GetAsync("Counter/countPlataformas");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Plataformas/" + i);
                    Plataforma obj2 = resp2.ResultAs<Plataforma>();

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

            cmbPlataformas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPlataformas.DataSource = dt;
            cmbPlataformas.ValueMember = "id";
            cmbPlataformas.DisplayMember = "nome";
            cmbPlataformas.SelectedValue = id;
            cmbPlataformas.Update();
        }

    }
}
