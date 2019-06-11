using LojadeJogo.DAO.Vendas;
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
    public partial class ExcVenda : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOVendas dao = new DAOVendas();

        public ExcVenda()
        {
            InitializeComponent();
            utils.preencherCombo(cmb_Vendas, dao.lista(), "idVendas", "descricao");
        }

        private void bttn_Excluir_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmb_Vendas.SelectedValue.ToString());
            dao.Excluir(idEscolhido);

            utils.preencherCombo(cmb_Vendas, dao.lista(), "idVendas", "descricao");
        }
    }
}
