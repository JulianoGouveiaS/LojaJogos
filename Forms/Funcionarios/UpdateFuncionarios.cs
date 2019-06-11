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
            utils.preencherCombo(cmb_Funcionarios, dao.lista(), "idFuncionarios", "nome");
        }

        private void bttn_Buscar_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmb_Funcionarios.SelectedValue.ToString());
            Funcionario funcionarioEscolhido = new Funcionario();
            funcionarioEscolhido = dao.buscarPorId(idEscolhido);
            txt_id.Text = funcionarioEscolhido.id.ToString();
            txt_salario.Text = funcionarioEscolhido.Salario.ToString();
            txt_nome.Text = funcionarioEscolhido.Nome;
            txt_id.Enabled = true;
            txt_salario.Enabled = true;
            txt_nome.Enabled = true;
        }

        private void bttn_Atualizar_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioEditado = new Funcionario();
            funcionarioEditado.id = int.Parse(txt_id.Text);
            funcionarioEditado.Nome = txt_nome.Text;
            funcionarioEditado.Salario = Convert.ToDouble(txt_salario.Text);
            dao.Editar(funcionarioEditado);

            txt_id.Enabled = false;
            txt_nome.Enabled = false;
            txt_salario.Enabled = false;
            utils.preencherCombo(cmb_Funcionarios, dao.lista(), "idFuncionarios", "nome");
        }
    }
}
