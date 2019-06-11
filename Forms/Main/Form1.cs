using LojadeJogo.Forms.Clientes;
using LojadeJogo.Forms.Plataformas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void plataformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadPlataforma form1 = new CadPlataforma();
            form1.MdiParent = this;
            form1.Show();
        }

        private void plataformasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcPlataforma form1 = new ExcPlataforma();
            form1.MdiParent = this;
            form1.Show();
        }

        private void plataformasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdatePlataformas form1 = new UpdatePlataformas();
            form1.MdiParent = this;
            form1.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFuncionarios form = new CadFuncionarios();
            form.MdiParent = this;
            form.Show();

        }

        private void plataformasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListaPlataformas form = new ListaPlataformas();
            form.MdiParent = this;
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadClientes form = new CadClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcCliente form = new ExcCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ListaCliente form = new ListaCliente();
            form.MdiParent = this;
            form.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            UpdateClientes form = new UpdateClientes();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            ExcFuncionario form = new ExcFuncionario();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionariosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateFuncionarios form = new UpdateFuncionarios();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionariosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListaFuncionarios form = new ListaFuncionarios();
            form.MdiParent = this;
            form.Show();
        }
    }
}
