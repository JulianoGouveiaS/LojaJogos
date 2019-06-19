using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Forms.Relatorios
{
    public partial class Relatorio : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        DataTable dt = new DataTable();

        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
        public async void lista()
        {
            this.client = connection.getClient();
            DataTable dt = new DataTable();
            int i = 0;
             dt.Columns.Add("id");
             dt.Columns.Add("nome");
            
            PlataformaBindingSource.DataSource = dt;
            i = 0;
            
            dt.Rows.Clear();
            
            FirebaseResponse resp1 = await client.GetAsync("Counter/countPlataformas");
            
            Counter_class obj1 = resp1.ResultAs<Counter_class>();
            
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {

                    FirebaseResponse resp2 = await client.GetAsync("Information/Plataformas/" + i);
                    Plataforma obj2 = resp2.ResultAs<Plataforma>();

                    DataRow row = dt.NewRow();
                    MessageBox.Show(obj2.Id + " " + obj2.Nome);
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            PlataformaBindingSource.ResetBindings(false);
            reportViewer1.RefreshReport();

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.lista();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
