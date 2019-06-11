using LojadeJogo.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Jogos
{
    class DAOJogos
    {
        ConnectionFactory connection = new ConnectionFactory();
        
        public void Salvar(Jogo jogo)
        {
            try
            {
                connection.Conectar();
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "INSERT INTO jogos(nome, preco, idPlataformas) VALUES(?nome, ?preco, ?idPlataformas)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = jogo.Nome;
                cmd.Parameters.Add("?preco", MySqlDbType.Double).Value = jogo.Preco;
                cmd.Parameters.Add("?idPlataformas", MySqlDbType.Int32).Value = jogo.IdPlataforma;
                cmd.ExecuteNonQuery(); 
                MessageBox.Show("Salvo com sucesso");
            } catch(Exception ex)
            { 

                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Nao deu certo a conexao!!");

            }
            finally
            {
               connection.Close();
            }
            
        }
        public Jogo buscarPorId(int id)
        {
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT * FROM jogos WHERE idJogos = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            Jogo jogoEncontrado = new Jogo();

            while (reader.Read())
            {
                jogoEncontrado.Id = int.Parse(reader["idJogos"].ToString());
                jogoEncontrado.IdPlataforma = int.Parse(reader["idPlataformas"].ToString());
                jogoEncontrado.Nome = reader["nome"].ToString();
                jogoEncontrado.Preco = double.Parse(reader["preco"].ToString());
            }

            reader.Close();
            connection.Close();
            return jogoEncontrado;

        }
        public DataTable lista()
        {
            ConnectionFactory connection = new ConnectionFactory();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();

            DataTable data = new DataTable("jogos");
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT * FROM jogos ORDER BY idJogos";
            data.Load(cmd.ExecuteReader());
            return data;
        }


        public void Excluir(Jogo jogo)
        {
            try
            { 
            connection.Conectar();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = connection.getConnection();

            cmd.CommandText = "DELETE FROM jogos WHERE idJogos = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = jogo.Id;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Nao deu certo a conexao!!");

            }
            finally
            {
                connection.Close();
            }




        }

        public void Editar(Jogo jogo)
        {

            try
            {
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "UPDATE jogos SET (nome = ?nome, preco = ?preco, idPlataformas = ?idPlataformas) where idJogos = ?idJogos";
                cmd.Parameters.Add("?nome", MySqlDbType.VarString).Value = jogo.Nome;
                cmd.Parameters.Add("?preco", MySqlDbType.Double).Value = jogo.Preco;
                cmd.Parameters.Add("?idPlataformas", MySqlDbType.Int32).Value = jogo.IdPlataforma;
                cmd.Parameters.Add("?idJogos", MySqlDbType.Int32).Value = jogo.Id;
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Nao deu certo a conexao!!");

            }
            finally
            {
                connection.Close();
            }
        }

       
    }
}
