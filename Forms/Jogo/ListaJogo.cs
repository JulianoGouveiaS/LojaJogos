using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Jogos;
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

namespace LojadeJogo.Forms.Jogo
{
    public partial class ListaJogo : Form
    {
        Utilitarios utilitarios = new Utilitarios();
        DAOClientes daoClientes = new DAOClientes();
        DAOJogos daoJ = new DAOJogos();
        public ListaJogo()
        {
            InitializeComponent();

            // utilitarios.lista("jogos", dataGridView_jogos, "idJogos");
    
            dataGridView_jogos.DataSource = daoJ.RightJoinLista();
        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_jogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
