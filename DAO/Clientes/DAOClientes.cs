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

                FirebaseResponse resp = await client.GetTaskAsync("Counter/countClientes");
                
                Counter_class get = resp.ResultAs<Counter_class>();

                var cliente2 = new Cliente
                {
                    Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                    Nome = cliente.Nome,
                    Telefone = cliente.Telefone
                };
                
                SetResponse response = await client.SetTaskAsync("Information/Clientes/" + cliente2.Id, cliente2);
                
                Cliente result = response.ResultAs<Cliente>();

                MessageBox.Show(result.Nome + " enviado com sucesso");
               

                var obj = new Counter_class
                {
                    cnt = cliente2.Id
                };

                SetResponse response1 = await client.SetTaskAsync("Counter/countClientes", obj);
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
                FirebaseResponse response = await client.DeleteTaskAsync("Information/Clientes/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally {
                FirebaseResponse resp = await client.GetTaskAsync("Counter/countClientes");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetTaskAsync("Counter/countClientes", obj);

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
            FirebaseResponse response = await client.GetTaskAsync("Information/Clientes/" + id);
            
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
            FirebaseResponse resp = await client.GetTaskAsync("Information/Clientes/" + cliente.Id);

            Cliente get = resp.ResultAs<Cliente>();
            var obj = new Cliente
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Telefone = cliente.Telefone
            };
            SetResponse response1 = await client.SetTaskAsync("Information/Clientes/" + cliente.Id, obj);
        }

    }
}

