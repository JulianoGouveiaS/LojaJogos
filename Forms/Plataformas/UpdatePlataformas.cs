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
  
            txtNome.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plataforma plataformaEditada = new Plataforma();
            plataformaEditada.id = int.Parse(txtId.Text);
            plataformaEditada.Nome = txtNome.Text;
            dao.Editar(plataformaEditada);

            txtId.Enabled = false;
            txtNome.Enabled = false;
            utils.preencherCombo(cmbPlataformas, dao.lista(), "idPlataformas", "nome");
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbPlataformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePlataformas_Load(object sender, EventArgs e)
        {

        }
    }
}
