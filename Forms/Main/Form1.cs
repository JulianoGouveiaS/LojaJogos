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

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadFuncionarios func = new CadFuncionarios();
            func.MdiParent = this;
            func.Show();

        }
    }
}
