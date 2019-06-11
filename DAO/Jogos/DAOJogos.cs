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
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = jogo.nome;
                cmd.Parameters.Add("?preco", MySqlDbType.Double).Value = jogo.preco;
                cmd.Parameters.Add("?idPlataformas", MySqlDbType.Int32).Value = jogo.idPlataforma;
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
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = jogo.idJogo;
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
                cmd.Parameters.Add("?nome", MySqlDbType.VarString).Value = jogo.nome;
                cmd.Parameters.Add("?preco", MySqlDbType.Double).Value = jogo.preco;
                cmd.Parameters.Add("?idPlataformas", MySqlDbType.Int32).Value = jogo.idPlataforma;
                cmd.Parameters.Add("?idJogos", MySqlDbType.Int32).Value = jogo.idJogo;
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

        public DataTable Listar(Jogo jogo)
        {

            DataTable tabela = new DataTable();
            try
            {
                connection.Conectar();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "SELECT * FROM jogos ORDER BY idJogos";
                MySqlDataReader leitor = cmd.ExecuteReader();

                tabela.Load(leitor);
               
            }
             catch(MySqlException ex)
            {

                MessageBox.Show(ex.StackTrace);
                MessageBox.Show("Nao deu certo a conexao!!");

            }
            finally
            {
                
                connection.Close();
            }

            return tabela;

        }
    }
}
