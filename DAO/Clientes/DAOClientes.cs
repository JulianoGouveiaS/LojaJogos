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


    }
}

