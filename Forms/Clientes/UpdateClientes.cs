using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Plataformas;
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

namespace LojadeJogo.Forms.Clientes
{
    public partial class UpdateClientes : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOClientes dao = new DAOClientes();


        public UpdateClientes()
        {
            InitializeComponent();

            utils.preencherCombo(cmbClientes, dao.lista(), "idClientes", "nome");
        }

        private void cmbPlataformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmbClientes.SelectedValue.ToString());
            Cliente clienteEscolhido = new Cliente();
            clienteEscolhido = dao.buscarPorId(idEscolhido);
            txtId.Text = clienteEscolhido.Id.ToString();
            txtNome.Text = clienteEscolhido.Nome;
            txt_tel.Text = clienteEscolhido.Telefone.ToString();
          
            txtNome.Enabled = true;
            txt_tel.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente clienteEscolhido = new Cliente();
            clienteEscolhido.Id = int.Parse(txtId.Text);
            clienteEscolhido.Nome = txtNome.Text;
            clienteEscolhido.Telefone = Int64.Parse(txt_tel.Text);
            dao.Editar(clienteEscolhido);

            txtId.Enabled = false;
            txtNome.Enabled = false;
            txt_tel.Enabled = false;
            utils.preencherCombo(cmbClientes, dao.lista(), "idClientes", "nome");
        }
    }
}
