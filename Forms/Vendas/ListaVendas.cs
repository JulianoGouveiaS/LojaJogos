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

namespace LojadeJogo.Forms.Vendas
{
    public partial class ListaVendas : Form
    {
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();

        public ListaVendas()
        {
            InitializeComponent();
            utils.lista("vendas", dataGridView1, "idVendas");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
