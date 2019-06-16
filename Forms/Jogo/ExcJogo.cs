using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Jogos;
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

namespace LojadeJogo.Forms.Jogo
{
    public partial class ExcJogo : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOJogos daoJogos = new DAOJogos();
        DataTable tabela = new DataTable();
        Utilitarios utilitarios = new Utilitarios();
        Domain.Jogo jogo = new Domain.Jogo();

        public ExcJogo()
        {
            InitializeComponent();
            daoJogos.preencheCombo(comboBox_Jogos);
            
            
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string idEscolhido = comboBox_Jogos.SelectedValue.ToString();
            daoJogos.Excluir(idEscolhido);
            daoJogos.preencheCombo(comboBox_Jogos);

        }

      
    }
}
