﻿using System;
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
    public partial class CadFuncionarios : Form
    {
        public CadFuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Adicionar_Click(object sender, EventArgs e)
        {
            DAOFuncionarios dao = new DAOFuncionarios();
            Funcionario func = new Funcionario();
            func.Nome = txt_Nome.Text;
            func.Salario = txt_Salario.Text;
            dao.salvar(func);
        }
    }
}
