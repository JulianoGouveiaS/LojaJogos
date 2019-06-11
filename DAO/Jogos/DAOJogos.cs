using LojadeJogo.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                MySqlConnection conexao = connection.getConnection();
                MySqlCommand cmd = new MySqlCommand();
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
    }
}
