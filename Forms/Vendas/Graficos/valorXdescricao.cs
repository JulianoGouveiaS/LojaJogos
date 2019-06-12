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

namespace LojadeJogo.Forms.Vendas.Graficos
{
    public partial class valorXdescricao : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        public valorXdescricao()
        {
            InitializeComponent();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "" +
                "SELECT V.descricao as Descricao, V.valor as Valor_Total " +
                "FROM vendas as V";
            cmd.Connection = connection.getConnection();
            MySqlDataReader myDataReader;

            try
            {
                myDataReader = cmd.ExecuteReader();
                while (myDataReader.Read())
                {
                    this.chart1.Series["Vendas"].Points.AddXY(myDataReader.GetString("Descricao"), myDataReader.GetDouble("Valor_Total"));

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
