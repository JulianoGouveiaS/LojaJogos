﻿using LojadeJogo.DAO.Plataformas;
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

namespace LojadeJogo.Forms.Clientes
{
    public partial class ListaCliente : Form
    {
        Utilitarios utils = new Utilitarios();
        DataSet conexaoDataset = new DataSet();
        public ListaCliente()
        {
            InitializeComponent();
            utils.lista("clientes", dataGridView1, "idClientes");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
