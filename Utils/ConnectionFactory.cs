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

        //Fazer conexao com banco de dados
        public void Conectar()
        {
            try
            {
                //Conexao Vitor
               // connection = new MySqlConnection("datasource=127.0.0.1;port=3306;database=lojadejogos;username=root;password=baseball64");

                //Conexao Juliano
                connection = new MySqlConnection("datasource=127.0.0.1;port=3306;database=lojadejogos;username=root;password=admin");

                connection.Open();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
