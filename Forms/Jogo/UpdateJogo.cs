using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Forms.Firebase;
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
    public partial class UpdateJogo : Form
    {
        Utils.Utilitarios utils = new Utils.Utilitarios();
        DAOJogos daoJogos = new DAOJogos();
        DaoPlataformas daoPlataformas = new DaoPlataformas();

        public UpdateJogo()
        {
            InitializeComponent();

            daoJogos.preencheCombo(comboBox_jogo);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Domain.Jogo jogoEscolhido = new Domain.Jogo();
            jogoEscolhido.Id = txt_id.Text;
            jogoEscolhido.Nome = txt_nome.Text;
            jogoEscolhido.IdPlataforma = comboBox_plataforma.SelectedValue.ToString();
            jogoEscolhido.Preco = txt_Preco.Text;
            daoJogos.Editar(jogoEscolhido);

            daoJogos.preencheCombo(comboBox_jogo);
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            string idEscolhido = comboBox_jogo.SelectedValue.ToString();

            daoJogos.BuscarPorId(idEscolhido, txt_id, txt_nome, comboBox_plataforma, txt_Preco);
        }
        

        private void comboBox_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
