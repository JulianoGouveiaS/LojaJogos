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

namespace LojadeJogo.Forms.Plataformas
{
    public partial class UpdatePlataformas : Form
    {
        Utilitarios utils = new Utilitarios();
        DaoPlataformas dao = new DaoPlataformas();

        public UpdatePlataformas()
        {
            InitializeComponent();
            utils.preencherCombo(cmbPlataformas, dao.lista(), "idPlataformas", "nome");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmbPlataformas.SelectedValue.ToString());
            Plataforma plataformaEscolhida = new Plataforma();
            plataformaEscolhida = dao.buscarPorId(idEscolhido);
            txtId.Text = plataformaEscolhida.id.ToString();
            txtNome.Text = plataformaEscolhida.Nome;
            txtId.Enabled = true;
            txtNome.Enabled = true;
        }
    }
}
