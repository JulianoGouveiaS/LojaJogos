using LojadeJogo.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Vendas
{
    class DAOVendas
    {

        ConnectionFactory connection = new ConnectionFactory();


        public void salvar(Venda venda)
        {

            try
            {
                connection.Conectar();
                // connectbd();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = connection.getConnection();
                cmd.CommandText = "INSERT INTO vendas(descricao, valor, idClientes, idJogos, idFuncionarios) VALUES(?desc, ?vl, ?idC, ?idJ, ?idF)";
                cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = venda.Descricao;
                cmd.Parameters.Add("?vl", MySqlDbType.Double).Value = venda.Valor;
                cmd.Parameters.Add("?idC", MySqlDbType.Int32).Value = venda.IdCliente;
                cmd.Parameters.Add("?idJ", MySqlDbType.Int32).Value = venda.IdJogo;
                cmd.Parameters.Add("?idF", MySqlDbType.Int32).Value = venda.IdFuncionario;
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
            cmd.CommandText = "DELETE from vendas WHERE idVendas = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader leitor = cmd.ExecuteReader();
            leitor.Read();

        }

        public void Editar(Venda venda)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "UPDATE vendas SET descricao = ?desc, valor = ?vl, idClientes = ?idC, idJogos = ?idJ, idFuncionarios = ?idF WHERE idVendas = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.VarChar).Value = venda.Id;
            cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = venda.Descricao;
            cmd.Parameters.Add("?vl", MySqlDbType.Double).Value = venda.Valor;
            cmd.Parameters.Add("?idC", MySqlDbType.Int32).Value = venda.IdCliente;
            cmd.Parameters.Add("?idJ", MySqlDbType.Int32).Value = venda.IdJogo;
            cmd.Parameters.Add("?idF", MySqlDbType.Int32).Value = venda.IdFuncionario;
            cmd.ExecuteNonQuery();

        }

        public DataTable lista()
        {
            ConnectionFactory connection = new ConnectionFactory();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();

            DataTable data = new DataTable("vendas");
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT idVendas, descricao FROM vendas ORDER BY idVendas";
            data.Load(cmd.ExecuteReader());
            return data;
        }

        public Venda buscarPorId(int id)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT * FROM vendas WHERE idVendas = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            Venda vendaEncontrada = new Venda();

            while (reader.Read())
            {
                vendaEncontrada.Id = int.Parse(reader["idVendas"].ToString());
                vendaEncontrada.Descricao = reader["descricao"].ToString();
                vendaEncontrada.Valor = double.Parse(reader["valor"].ToString());
                vendaEncontrada.IdCliente = int.Parse(reader["idClientes"].ToString());
                vendaEncontrada.IdJogo = int.Parse(reader["idJogos"].ToString());
                vendaEncontrada.IdFuncionario = int.Parse(reader["idFuncionarios"].ToString());

            }

            reader.Close();
            connection.Close();
            return vendaEncontrada;

        }

    }
}
