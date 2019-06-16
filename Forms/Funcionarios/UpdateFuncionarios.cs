using FireSharp.Interfaces;
using FireSharp.Response;
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

namespace LojadeJogo
{
    public partial class UpdateFuncionarios : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOFuncionarios dao = new DAOFuncionarios();

        public UpdateFuncionarios()
        {
            InitializeComponent();
            dao.preencheCombo(cmb_Funcionarios);
        }

        private void bttn_Buscar_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmb_Funcionarios.SelectedValue.ToString();
            Funcionario funcionarioEscolhido = new Funcionario();
            dao.BuscarPorId(idEscolhido, txt_id, txt_nome, txt_salario);
            txt_id.Enabled = true;
            txt_salario.Enabled = true;
            txt_nome.Enabled = true;
        }

        private void bttn_Atualizar_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioEditado = new Funcionario();
            funcionarioEditado.id = txt_id.Text;
            funcionarioEditado.Nome = txt_nome.Text;
            funcionarioEditado.Salario = txt_salario.Text;
            dao.Editar(funcionarioEditado);

            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            txt_salario.Enabled = false;
            dao.preencheCombo(cmb_Funcionarios);
        }
        
    }
}
