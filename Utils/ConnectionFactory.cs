using FireSharp.Config;
using FireSharp.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    class ConnectionFactory
    {
        MySqlConnection connection;
        IFirebaseClient client;

        //Fazer conexao com banco de dados
        public void Conectar()
        {
            try
            {
                //Conexao Vitor
                //connection = new MySqlConnection("datasource=127.0.0.1;port=3306;database=lojadejogos;username=root;password=baseball64");

                //Conexao Juliano
                connection = new MySqlConnection("datasource=127.0.0.1;port=3306;database=lojadejogos;username=root;password=admin");

                connection.Open();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        public IFirebaseClient getClient() {

            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "sVHBJ1TEcUkTCyWYwT30UDo5O8LAtuxbeGhpEpRb",
                BasePath = "https://loja-jogos-68e8d.firebaseio.com/"
            };

            client = new FireSharp.FirebaseClient(config);

            return client;

        }

        //Pegar conexao com banco de dados
        public MySqlConnection getConnection()
        {
            
            return connection;
        }

        //Fechar conexao
        public void Close()
        {
            this.connection.Close();
        }


    }
}
