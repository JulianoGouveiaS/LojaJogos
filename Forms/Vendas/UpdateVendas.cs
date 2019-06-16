using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Vendas;
using LojadeJogo.Domain;
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

namespace LojadeJogo.Forms.Vendas
{
    public partial class UpdateVendas : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOClientes daoC = new DAOClientes();
        DAOVendas daoV = new DAOVendas();
        DAOFuncionarios daoF = new DAOFuncionarios();
        DAOJogos daoJ = new DAOJogos();


        public UpdateVendas()
        {
            InitializeComponent();
            daoV.preencheCombo(cmbVendas);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bttn atualizar
            Venda v = new Venda();
            v.Id = txtId.Text;
            v.Descricao = txtDescricao.Text;
            v.Valor = txtValor.Text;
            v.IdCliente = cb_clientes.SelectedValue.ToString();
            v.IdFuncionario = cb_funcionarios.SelectedValue.ToString();
            v.IdJogo = cb_jogo.SelectedValue.ToString();
            daoV.Editar(v);

            daoV.preencheCombo(cmbVendas);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pesquisar bttn
            string idEscolhido = cmbVendas.SelectedValue.ToString();
            Venda vendaEscolhida = new Venda();
            daoV.BuscarPorId(idEscolhido, txtDescricao, txtId, txtValor, cb_jogo, cb_funcionarios, cb_clientes);
                    }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
