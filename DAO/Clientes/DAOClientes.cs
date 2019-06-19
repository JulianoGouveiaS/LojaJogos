using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Clientes
{
    class DAOClientes
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;

        public async void salvar(Cliente cliente)
        {
            try
            {
                /*    connection.Conectar();
                    // connectbd();
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = connection.getConnection();
                    cmd.CommandText = "INSERT INTO clientes(nome, telefone) VALUES(?nome, ?telefone)";
                    cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = cliente.Nome;
                    cmd.Parameters.Add("?telefone", MySqlDbType.Int64).Value = cliente.Telefone;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso");
                    */

                this.client = connection.getClient();

                FirebaseResponse resp = await client.GetAsync("Counter/countClientes");
                
                Counter_class get = resp.ResultAs<Counter_class>();

                var cliente2 = new Cliente
                {
                    Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone
                };
                
                SetResponse response = await client.SetAsync("Information/Clientes/" + cliente2.Id, cliente2);
                
                Cliente result = response.ResultAs<Cliente>();

                MessageBox.Show(result.Nome + " enviado com sucesso");
               

                var obj = new Counter_class
                {
                    cnt = cliente2.Id
                };

                SetResponse response1 = await client.SetAsync("Counter/countClientes", obj);
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
            /*  connection.Conectar();
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection.getConnection();
              cmd.CommandText = "DELETE from clientes WHERE idClientes = ?id";
              cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
              MySqlDataReader leitor = cmd.ExecuteReader();
              leitor.Read();
              */
            try
            {
                this.client = connection.getClient();
                FirebaseResponse response = await client.DeleteAsync("Information/Clientes/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally {
                FirebaseResponse resp = await client.GetAsync("Counter/countClientes");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetAsync("Counter/countClientes", obj);

            }

        }
        /*

        public DataTable Lista()
        {
            ConnectionFactory connection = new ConnectionFactory();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();

            DataTable data = new DataTable("clientes");
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT * FROM clientes ORDER BY idClientes";
            data.Load(cmd.ExecuteReader());
            return data;
            

         }
         */
        public async void BuscarPorId(string id, TextBox txtid, TextBox txtnome, TextBox txttel )
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetAsync("Information/Clientes/" + id);
            
            Cliente obj = response.ResultAs<Cliente>();

            
            txtid.Text = obj.Id;
            txtnome.Text = obj.Nome;
            txttel.Text = obj.Telefone;

        }


        public async void Editar(Cliente cliente)
        {
            /*
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            //UPDATE clientes SET nome = 'juliano', telefone = '11111111' WHERE idClientes = 1
            cmd.CommandText = "UPDATE clientes SET nome = ?nome, telefone = ?telefone WHERE idClientes = ?id";
            cmd.Parameters.Add("?nome", MySqlDbType.String).Value = cliente.Nome;
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = cliente.Id;
            cmd.Parameters.Add("?telefone", MySqlDbType.Int32).Value = cliente.Telefone;
            cmd.ExecuteNonQuery();
            */
            FirebaseResponse resp = await client.GetAsync("Information/Clientes/" + cliente.Id);

            Cliente get = resp.ResultAs<Cliente>();
            var obj = new Cliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };
            SetResponse response1 = await client.SetAsync("Information/Clientes/" + cliente.Id, obj);
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
            FirebaseResponse resp1 = await client.GetAsync("Counter/countClientes");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Clientes/" + i);
                    Cliente obj2 = resp2.ResultAs<Cliente>();

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
            dt.Columns.Add("telefone");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetAsync("Counter/countClientes");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Clientes/" + i);
                    Cliente obj2 = resp2.ResultAs<Cliente>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["telefone"] = obj2.Telefone;

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

