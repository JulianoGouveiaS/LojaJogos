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
            utils.preencherCombo(cmbVendas, daoV.lista(), "idVendas", "descricao");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bttn atualizar
            Venda v = new Venda();
            v.Id = int.Parse(txtId.Text);
            v.Descricao = txtDescricao.Text;
            v.Valor = double.Parse(txtValor.Text);
            v.IdCliente = int.Parse(cb_clientes.SelectedValue.ToString());
            v.IdFuncionario = int.Parse(cb_funcionarios.SelectedValue.ToString());
            v.IdJogo = int.Parse(cb_jogo.SelectedValue.ToString());
            daoV.Editar(v);

            utils.preencherCombo(cmbVendas, daoV.lista(), "idVendas", "descricao");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pesquisar bttn
            int idEscolhido = int.Parse(cmbVendas.SelectedValue.ToString());
            Venda vendaEscolhida = new Venda();
            vendaEscolhida = daoV.buscarPorId(idEscolhido);

            utils.preencherCombo(cb_clientes, daoC.lista(), "idClientes", "nome");
            cb_clientes.SelectedValue = vendaEscolhida.IdCliente;

            utils.preencherCombo(cb_funcionarios, daoF.lista(), "idFuncionarios", "nome");
            cb_funcionarios.SelectedValue = vendaEscolhida.IdFuncionario;

            utils.preencherCombo(cb_jogo, daoJ.lista(), "idJogos", "nome");
            cb_jogo.SelectedValue = vendaEscolhida.IdJogo;

            txtDescricao.Text = vendaEscolhida.Descricao;
            txtValor.Text = vendaEscolhida.Valor.ToString();
            txtId.Text = vendaEscolhida.Id.ToString();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
