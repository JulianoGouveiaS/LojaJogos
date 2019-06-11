using LojadeJogo.DAO.Clientes;
using LojadeJogo.Domain;
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
    public partial class CadClientes : Form
    {
        public CadClientes()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {

            DAOClientes dao = new DAOClientes();
            Cliente cliente = new Cliente();
            cliente.Nome = txt_Nome.Text;
            cliente.Telefone = Convert.ToInt64(txt_Tel.Text);
            dao.salvar(cliente);
        }
    }
}
