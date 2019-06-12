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
    public partial class ExcJogo : Form
    {
        public ExcJogo()
        {
            InitializeComponent();
            tabela = daoJogos.lista();
            utilitarios.preencherCombo(comboBox_Jogos, tabela, "idJogos", "nome");
            
            
        }
        DAOJogos daoJogos = new DAOJogos();
        DataTable tabela = new DataTable();
        Utilitarios utilitarios = new Utilitarios();
        Domain.Jogo jogo = new Domain.Jogo();
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            jogo.Id = int.Parse(comboBox_Jogos.SelectedValue.ToString());

            daoJogos.Excluir(jogo);
        }
    }
}
