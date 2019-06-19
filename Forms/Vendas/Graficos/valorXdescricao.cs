using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Utils;
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
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        public valorXdescricao()
        {
            InitializeComponent();
            carregaGrafico();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        public async void carregaGrafico()
        {
            this.client = connection.getClient();

            FirebaseResponse resp1 = await client.GetAsync("Counter/countVendas");

            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            int cnt = Convert.ToInt32(obj1.cnt);
            int i;
            for (i = 0; i <= cnt; i++)
            {
                try
                {

                    FirebaseResponse resp2 = await client.GetAsync("Information/Vendas/" + i);
                    Domain.Venda obj2 = resp2.ResultAs<Domain.Venda>();

                   
                    this.chart1.Series["Vendas"].Points.AddXY(obj2.Descricao,obj2.Valor);

                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
