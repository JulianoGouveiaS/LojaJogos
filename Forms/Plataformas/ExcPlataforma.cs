using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Forms.Plataformas
{
    public partial class ExcPlataforma : Form
    {
        Utilitarios utils = new Utilitarios();
        DaoPlataformas dao = new DaoPlataformas();

        public ExcPlataforma()
        {
            InitializeComponent();
            utils.preencherCombo(cmbPlat, dao.lista(), "idPlataformas", "nome");
        }

        private void cmbPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmbPlat.SelectedValue.ToString());
            dao.Excluir(idEscolhido);
            utils.preencherCombo(cmbPlat, dao.lista(), "idPlataformas", "nome");

        }
    }
}
