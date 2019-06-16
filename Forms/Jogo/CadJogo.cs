using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojadeJogo.DAO.Jogos;
namespace LojadeJogo.Forms.Jogo
{
    public partial class CadJogo : Form
    {
        public object DAOjogos { get; private set; }

        public CadJogo()
        {
            InitializeComponent();
            daoPlataformas.preencheCombo(comboBox_plataforma);
            
        }

        DataTable tabelaPlataforma = new DataTable();
        DAO.Plataformas.DaoPlataformas daoPlataformas = new DAO.Plataformas.DaoPlataformas();
        Utils.Utilitarios utils = new Utils.Utilitarios();


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            DAOJogos jogoDAO = new DAOJogos();
            Domain.Jogo jogoDomain = new Domain.Jogo();

            jogoDomain.Nome = txt_nome.Text;
            jogoDomain.Preco = txt_preco.Text.ToString();
            jogoDomain.IdPlataforma = comboBox_plataforma.SelectedValue.ToString();

            jogoDAO.Salvar(jogoDomain);
            

            
        }

        private void comboBox_plataforma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
