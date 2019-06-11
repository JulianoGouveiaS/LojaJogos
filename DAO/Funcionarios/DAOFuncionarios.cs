using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    class DAOFuncionarios
    {
        ConnectionFactory connection = new ConnectionFactory();

        public void salvar(Funcionario funcionarios)
        {


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

            public void Excluir(int id)
            {
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "DELETE from funcionarios WHERE idFuncionarios = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                MySqlDataReader leitor = cmd.ExecuteReader();
                leitor.Read();

            }

            public void Editar(Funcionario funcionarios)
            {
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "UPDATE funcionarios SET nome, salario = ?nome, ?salario WHERE idFuncionarios = ?id";
                cmd.Parameters.Add("?nome", MySqlDbType.String).Value = funcionarios.Nome;
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = funcionarios.id;
                cmd.Parameters.Add("?salario", MySqlDbType.Double).Value = funcionarios.Salario;
                cmd.ExecuteNonQuery();

            }

            public DataTable lista()
            {
                ConnectionFactory connection = new ConnectionFactory();
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();

                DataTable data = new DataTable("funcionarios");
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "SELECT idFuncionarios, nome, salario FROM funcionarios ORDER BY idFuncionarios";
                data.Load(cmd.ExecuteReader());
                return data;
            }

            public Funcionario buscarPorId(int id)
            {
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "SELECT * FROM funcionarios WHERE idFuncionarios = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
                MySqlDataReader reader = cmd.ExecuteReader();
                Funcionario funcionarioEncontrado = new Funcionario();

                while (reader.Read())
                {
                    funcionarioEncontrado.id = int.Parse(reader["idFuncionarios"].ToString());
                    funcionarioEncontrado.Nome = reader["nome"].ToString();
                    funcionarioEncontrado.Salario = Convert.ToDouble(reader["salario"].ToString());
                }

                reader.Close();
                connection.Close();
                return funcionarioEncontrado;

            }

    }

}


