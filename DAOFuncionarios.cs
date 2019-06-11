using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                cmd.CommandText = "INSERT INTO funcionarios(nome) VALUES(?nome)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = funcionarios.Nome;
                cmd.CommandText = "INSERT INTO funcionarios(salario) VALUES(?salario)";
                cmd.Parameters.Add("?nome", MySqlDbType.VarChar).Value = funcionarios.Salario;
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

            public void Editar(Funcionarios funcionarios)
            {
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "UPDATE funcionarios SET nome = ?nome WHERE idFuncionarios = ?id";
                cmd.Parameters.Add("?nome", MySqlDbType.String).Value = funcionarios.Nome;
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = funcionarios.id;
                cmd.CommandText = "UPDATE funcionarios SET salario = ?salario WHERE idFuncionarios = ?id";
                cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = funcionarios.Salario;
                cmd.ExecuteNonQuery();

            }

            public DataTable lista()
            {
                ConnectionFactory connection = new ConnectionFactory();
                connection.Conectar();
                MySqlCommand cmd = new MySqlCommand();

                DataTable data = new DataTable("funcionarios");
                cmd.Connection = connection.getConnection();
                cmd.CommandText = "SELECT idFuncionarios, nome FROM funcionarios ORDER BY idFuncionarios";
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
                Funcionarios funcionarioEncontrado = new Funcionarios();

                while (reader.Read())
                {
                    funcionarioEncontrado.id = int.Parse(reader["idPlataformas"].ToString());
                    funcionarioEncontrado.Nome = reader["nome"].ToString();
                    funcionarioEncontrado.Salario = int.Parse(reader["salario"].ToString());
                }

                reader.Close();
                connection.Close();
                return funcionarioEncontrado;

            }

        }


    }
}
