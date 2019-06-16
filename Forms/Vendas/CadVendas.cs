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

        int selectedDefaultJogo = 0;

        public CadVendas()
        {
            InitializeComponent();

            daoC.preencheCombo(cb_cliente);
            daoF.preencheCombo(cb_funcionario);
            daoJ.preencheCombo(cb_jogo);
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Descricao = txt_desc.Text;
            v.IdCliente = cb_cliente.SelectedValue.ToString();
            v.IdFuncionario = cb_funcionario.SelectedValue.ToString();
            v.IdJogo = cb_jogo.SelectedValue.ToString();
            v.Valor = lbl_total.Text;
            daoV.salvar(v);


        }

        private void cb_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_jogo.SelectedValue.ToString() != "System.Data.DataRowView") { 
                string indexJogoSelecionado = cb_jogo.SelectedValue.ToString();
                Domain.Jogo jogoEscolhido = new Domain.Jogo();
                daoJ.updateValor(indexJogoSelecionado, lbl_total);
             
             }
        }

        
    }
}
