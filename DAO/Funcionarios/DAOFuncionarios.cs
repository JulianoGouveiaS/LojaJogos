﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;

namespace LojadeJogo
{
    class DAOFuncionarios
    {
        ConnectionFactory connection = new ConnectionFactory();

        IFirebaseClient client;

        public async void salvar(Funcionario funcionario)
        {


            try
            {
                /*
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
           }*/

                this.client = connection.getClient();

                FirebaseResponse resp = await client.GetTaskAsync("Counter/countFuncionarios");

                Counter_class get = resp.ResultAs<Counter_class>();

                var Funcionario2 = new Funcionario
                {
                    Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                    Nome = funcionario.Nome,
                    Salario = funcionario.Salario
                };

                SetResponse response = await client.SetTaskAsync("Information/Funcionarios/" + Funcionario2.Id, Funcionario2);

                Cliente result = response.ResultAs<Cliente>();

                MessageBox.Show(result.Nome + " enviado com sucesso");


                var obj = new Counter_class
                {
                    cnt = Funcionario2.Id
                };

                SetResponse response1 = await client.SetTaskAsync("Counter/countFuncionarios", obj);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo o inesrt!!");
            }
            finally
            {

            }
        }

            public async void Excluir(int id)
            {
            /*  connection.Conectar();
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection.getConnection();
              cmd.CommandText = "DELETE from funcionarios WHERE idFuncionarios = ?id";
              cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = id;
              MySqlDataReader leitor = cmd.ExecuteReader();
              leitor.Read();
              */
            try
            {
                this.client = connection.getClient();
                FirebaseResponse response = await client.DeleteTaskAsync("Information/Funcionarios/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                FirebaseResponse resp = await client.GetTaskAsync("Counter/countFuncionarios");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetTaskAsync("Counter/countFuncionarios", obj);

            }
        }

            public async void Editar(Funcionario funcionario)
            {
            /*  connection.Conectar();
              MySqlCommand cmd = new MySqlCommand();
              cmd.Connection = connection.getConnection();
              cmd.CommandText = "UPDATE funcionarios SET nome = ?nome, salario = ?salario WHERE idFuncionarios = ?id";
              cmd.Parameters.Add("?nome", MySqlDbType.String).Value = funcionarios.Nome;
              cmd.Parameters.Add("?id", MySqlDbType.Int32).Value = funcionarios.id;
              cmd.Parameters.Add("?salario", MySqlDbType.Double).Value = funcionarios.Salario;
              cmd.ExecuteNonQuery();
              */
            FirebaseResponse resp = await client.GetTaskAsync("Information/Funcionarios/" + funcionario.Id);

            Funcionario get = resp.ResultAs<Funcionario>();
            var obj = new Funcionario
            {
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                Salario = funcionario.Salario
            };
            SetResponse response1 = await client.SetTaskAsync("Information/Funcionarios/" + funcionario.Id, obj);
        }
        /*
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
            }*/

        public async void BuscarPorId(string id, TextBox txtid, TextBox txtnome, TextBox txtsal)
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetTaskAsync("Information/Funcionarios/" + id);

            Funcionario obj = response.ResultAs<Funcionario>();


            txtid.Text = obj.Id;
            txtnome.Text = obj.Nome;
            txtsal.Text = obj.Salario;

        }
    }

}


