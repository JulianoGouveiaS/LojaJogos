using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace LojadeJogo.Forms.Plataformas
{
    public partial class UpdatePlataformas : Form
    {
        Utilitarios utils = new Utilitarios();
        DaoPlataformas dao = new DaoPlataformas();

        public UpdatePlataformas()
        {
            InitializeComponent();
            dao.preencheCombo(cmbPlataformas);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmbPlataformas.SelectedValue.ToString();

            dao.buscarPorId(idEscolhido, txtId, txtNome);
            txtNome.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plataforma plataformaEditada = new Plataforma();
            plataformaEditada.id = txtId.Text;
            plataformaEditada.Nome = txtNome.Text;
            dao.Editar(plataformaEditada);

            dao.preencheCombo(cmbPlataformas);

            txtNome.Enabled = false;
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
