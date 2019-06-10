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

        public void salvar(Plataforma plataforma)
        {

            ConnectionFactory connection = new ConnectionFactory();
           
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
    }
}
