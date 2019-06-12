using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Vendas;
using LojadeJogo.Utils;
using LojadeJogo.Domain;
using System;
using System.Windows.Forms;

namespace LojadeJogo.Forms.Vendas
{
    public partial class CadVendas : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOVendas daoV = new DAOVendas();
        DAOClientes daoC = new DAOClientes();
        DAOFuncionarios daoF = new DAOFuncionarios();
        DAOJogos daoJ = new DAOJogos();
        Jogo j = new Jogo();
        
        

        int selectedDefaultJogo = 0;

        public CadVendas()
        {
            InitializeComponent();

            utils.preencherCombo(cb_cliente, daoC.lista(), "idClientes", "nome");
            utils.preencherCombo(cb_jogo, daoJ.lista(), "idJogos", "nome");
            utils.preencherCombo(cb_funcionario, daoF.lista(), "idFuncionarios", "nome");
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {

        }

        private void cb_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexJogoSelecionado = int.Parse(cb_jogo.SelectedValue.ToString());
             
        }
    }
}
