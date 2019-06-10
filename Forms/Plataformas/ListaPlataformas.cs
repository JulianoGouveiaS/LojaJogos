using LojadeJogo.DAO.Plataformas;
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

namespace LojadeJogo.Forms.Plataformas
{
    public partial class ListaPlataformas : Form
    {
        Utilitarios utils = new Utilitarios();
        DaoPlataformas dao = new DaoPlataformas();
        DataSet conexaoDataset = new DataSet();

        public ListaPlataformas()
        {
            InitializeComponent();
            utils.lista("plataformas", dataGridView1, "idPlataformas");
        }

      
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
