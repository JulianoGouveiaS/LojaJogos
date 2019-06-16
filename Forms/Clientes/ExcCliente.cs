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
    public partial class ExcCliente : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOClientes dao = new DAOClientes();

        public ExcCliente()
        {
            InitializeComponent();
            dao.preencheCombo(cmbClientes);

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmbClientes.SelectedValue.ToString();
            dao.Excluir(idEscolhido);
            dao.preencheCombo(cmbClientes);
        }

        private void cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
    }
}
