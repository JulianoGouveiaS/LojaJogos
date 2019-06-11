using LojadeJogo.Domain;
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

        public void salvar(Cliente cliente)
        {
            try
            {
                connection.Conectar();
                // connectbd();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection.getConnection();
                cmd.CommandText = "INSERT INTO clientes(nome, telefone) VALUES(?nome, ?telefone)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = cliente.Nome;
                cmd.Parameters.Add("?telefone", MySqlDbType.Int64).Value = cliente.Telefone;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Salvo com sucesso");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo a conexao!!");
            }
            finally
            {
                connection.Close();
            }
        }


        public void Excluir(int id)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "DELETE from clientes WHERE idClientes = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader leitor = cmd.ExecuteReader();
            leitor.Read();

        }


        public DataTable lista()
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

        public Cliente buscarPorId(int id)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT * FROM clientes WHERE idClientes = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            Cliente clienteEncontrado = new Cliente();

            while (reader.Read())
            {
                clienteEncontrado.Id = int.Parse(reader["idClientes"].ToString());
                clienteEncontrado.Nome = reader["nome"].ToString();
                clienteEncontrado.Telefone = Int64.Parse(reader["telefone"].ToString());
            }

            reader.Close();
            connection.Close();
            return clienteEncontrado;

        }


        public void Editar(Cliente cliente)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            //UPDATE clientes SET nome = 'juliano', telefone = '11111111' WHERE idClientes = 1
            cmd.CommandText = "UPDATE clientes SET nome = ?nome, telefone = ?telefone WHERE idClientes = ?id";
            cmd.Parameters.Add("?nome", MySqlDbType.String).Value = cliente.Nome;
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = cliente.Id;
            cmd.Parameters.Add("?telefone", MySqlDbType.Int32).Value = cliente.Telefone;
            cmd.ExecuteNonQuery();

        }

    }
}

