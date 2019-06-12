using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Forms.Jogo.Graficos
{
    public partial class nomeXplataforma : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        public nomeXplataforma()
        {
            InitializeComponent();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "" +
                "SELECT J.nome as Nome_Jogo, P.nome as Plataforma " +
                "FROM jogos as J " +
                "LEFT JOIN plataformas as P ON J.idPlataformas = P.idPlataformas ";
            cmd.Connection = connection.getConnection();
            MySqlDataReader myDataReader;

            try
            {
                myDataReader = cmd.ExecuteReader();
                while (myDataReader.Read())
                {
                    
                    this.chart1.Series["Jogos"].Points.AddXY(myDataReader.GetString("Plataforma"), myDataReader.GetString("Nome_Jogo"));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
