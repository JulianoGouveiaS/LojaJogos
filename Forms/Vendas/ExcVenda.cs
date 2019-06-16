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
            dao.preencheCombo(cmb_Vendas);
        }

        private void bttn_Excluir_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmb_Vendas.SelectedValue.ToString();
            dao.Excluir(idEscolhido);

            dao.preencheCombo(cmb_Vendas);
        }
    }
}
