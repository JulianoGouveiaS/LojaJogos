using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
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

namespace LojadeJogo.Forms.Clientes
{
    public partial class UpdateClientes : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOClientes dao = new DAOClientes();


        public UpdateClientes()
        {
            InitializeComponent();

           dao.preencheCombo(cmbClientes);
        }

        private void cmbPlataformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmbClientes.SelectedValue.ToString();

            dao.BuscarPorId(idEscolhido, txtId, txtNome, txt_tel);
          
            txtNome.Enabled = true;
            txt_tel.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente clienteEscolhido = new Cliente();
            clienteEscolhido.Id = txtId.Text;
            clienteEscolhido.Nome = txtNome.Text;
            clienteEscolhido.Telefone = txt_tel.Text;
            dao.Editar(clienteEscolhido);

            txtId.Enabled = false;
            txtNome.Enabled = false;
            txt_tel.Enabled = false;
            dao.preencheCombo(cmbClientes);
        }

       
    }
}
