using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Plataformas;
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
            utils.preencherCombo(cmbClientes, dao.lista(), "idClientes", "nome");

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmbClientes.SelectedValue.ToString());
            dao.Excluir(idEscolhido);
            utils.preencherCombo(cmbClientes, dao.lista(), "idClientes", "nome");
        }
    }
}
