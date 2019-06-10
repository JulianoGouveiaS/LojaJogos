using LojadeJogo.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Plataformas
{
    public class DaoPlataformas
    {
        ConnectionFactory connection = new ConnectionFactory();


        public void salvar(Plataforma plataforma)
        {

            try
            {
                 connection.Conectar();
                // connectbd();
                MySqlCommand cmd = new MySqlCommand();
              

                cmd.Connection = connection.getConnection();
                cmd.CommandText = "INSERT INTO plataformas(nome) VALUES(?nome)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = plataforma.Nome;
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
            cmd.CommandText = "DELETE from plataformas WHERE idPlataformas = ?id";
            cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
            MySqlDataReader leitor = cmd.ExecuteReader();
            leitor.Read();
   
        }




    }
}
