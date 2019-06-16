﻿using LojadeJogo.DAO.Clientes;
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

         //   utils.preencherCombo(cb_cliente, daoC.lista(), "idClientes", "nome");
            utils.preencherCombo(cb_jogo, daoJ.lista(), "idJogos", "nome");
         //   utils.preencherCombo(cb_funcionario, daoF.lista(), "idFuncionarios", "nome");
        }

        private void btn_efetuar_Click(object sender, EventArgs e)
        {
            Venda v = new Venda();
            v.Descricao = txt_desc.Text;
            v.IdCliente = int.Parse(cb_cliente.SelectedValue.ToString());
            v.IdFuncionario = int.Parse(cb_funcionario.SelectedValue.ToString());
            v.IdJogo = int.Parse(cb_jogo.SelectedValue.ToString());
            v.Valor = double.Parse(lbl_total.Text);
            daoV.salvar(v);


        }

        private void cb_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_jogo.SelectedValue.ToString() != "System.Data.DataRowView") { 
            int indexJogoSelecionado = int.Parse(cb_jogo.SelectedValue.ToString());
            Domain.Jogo jogoEscolhido = new Domain.Jogo();
            jogoEscolhido = daoJ.buscarPorId(indexJogoSelecionado);
            lbl_total.Text = jogoEscolhido.Preco.ToString();
        }
        }

        
    }
}
