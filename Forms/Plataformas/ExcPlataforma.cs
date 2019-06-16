using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
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
            dao.preencheCombo(cmbPlat);
        }

        private void cmbPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmbPlat.SelectedValue.ToString();
            dao.Excluir(idEscolhido);
            dao.preencheCombo(cmbPlat);

        }

        
    }
}
