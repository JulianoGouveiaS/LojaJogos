using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    class DAOFuncionarios
    {
        public void salvar(Funcionarios funcionarios)
        {
            ConnectionFactory connection = new ConnectionFactory();

            try
            {
                connection.Conectar();
                // connectbd();
                MySqlCommand cmd = new MySqlCommand();


                cmd.Connection = connection.getConnection();
                cmd.CommandText = "INSERT INTO funcionarios(nome, salario) VALUES(?nome, ?salario)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = funcionarios.Nome;
                cmd.Parameters.Add("?salario", MySqlDbType.Double).Value = funcionarios.Salario;
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
