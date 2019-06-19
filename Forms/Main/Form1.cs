using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Forms.Backup;
using LojadeJogo.Forms.Clientes;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Forms.Jogo;
using LojadeJogo.Forms.Jogo.Graficos;
using LojadeJogo.Forms.Plataformas;
using LojadeJogo.Forms.Relatorios;
using LojadeJogo.Forms.Vendas;
using LojadeJogo.Forms.Vendas.Graficos;
using LojadeJogo.Utils;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo
{
    public partial class FormPrincipal : Form
    {
        string adm;
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();
        public FormPrincipal(string isAdm)
        {
            this.adm = isAdm;
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

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadJogo form = new CadJogo();
            form.MdiParent = this;
            form.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadVendas form = new CadVendas();
            form.MdiParent = this;
            form.Show();

        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcVenda form = new ExcVenda();
            form.MdiParent = this;
            form.Show();
        }

        private void vendasToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            UpdateVendas form = new UpdateVendas();
            form.MdiParent = this;
            form.Show();
        }

        private void vendasToolStripMenuItem3_Click(object sender, EventArgs e)
        {

            ListaVendas form = new ListaVendas();
            form.MdiParent = this;
            form.Show();
        }

        private void jogosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcJogo form = new ExcJogo();
            form.MdiParent = this;
            form.Show();
        }

        private void jogosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UpdateJogo form = new UpdateJogo();
            form.MdiParent = this;
            form.Show();
        }

        private void jogosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ListaJogo form = new ListaJogo();
            form.MdiParent = this;
            form.Show();

        }

        private void valorXDescricaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorXdescricao form = new valorXdescricao();
            form.MdiParent = this;
            form.Show();
        }

        private void nomeXplataformaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            nomeXplataforma form = new nomeXplataforma();
            form.MdiParent = this;
            form.Show();
        }

        private void firebaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            teste form = new teste();
            form.MdiParent = this;
            form.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void descricaoXValorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorXdescricao form = new valorXdescricao();
            form.MdiParent = this;
            form.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vendasToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Relatorio form = new Relatorio();
            form.MdiParent = this;
            form.Show();

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupList form = new BackupList();
            form.MdiParent = this;
            form.Show();

        }
    }
}
