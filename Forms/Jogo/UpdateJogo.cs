using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Plataformas;
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
        public UpdateJogo()
        {
            InitializeComponent();
            tabelaJogo = daoJogos.lista();
            utilitarios.preencherCombo(comboBox_jogo, tabelaJogo, "idJogos", "nome");
            

        }

        DAOJogos daoJogos = new DAOJogos();
        Domain.Jogo domainJogo = new Domain.Jogo();
        Utils.Utilitarios utilitarios = new Utils.Utilitarios();
        DataTable tabelaJogo = new DataTable();
        DataTable tabelaPlataforma = new DataTable();
        DaoPlataformas daoPlataformas = new DaoPlataformas();

        private void button1_Click(object sender, EventArgs e)
        {
            domainJogo.Nome = txt_nome.Text;
            domainJogo.Preco = double.Parse(txt_preco.Text);
            domainJogo.IdPlataforma = int.Parse(comboBox_plataforma.SelectedValue.ToString());
            domainJogo.Id = int.Parse(txt_id.Text);
            daoJogos.Editar(domainJogo);

        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            domainJogo = daoJogos.buscarPorId(int.Parse(comboBox_jogo.SelectedValue.ToString()));
            txt_id.Text = domainJogo.Id.ToString();
            txt_nome.Text = domainJogo.Nome;
            txt_preco.Text = domainJogo.Preco.ToString();
            tabelaPlataforma = daoPlataformas.lista();
            utilitarios.preencherCombo(comboBox_plataforma, tabelaPlataforma, "idPlataformas", "nome");
        }
    }
}
