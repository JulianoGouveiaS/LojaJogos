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
    public partial class ExcFuncionario : Form
    {

        Utilitarios utils = new Utilitarios();
        DAOFuncionarios dao = new DAOFuncionarios();

        
            public ExcFuncionario()
            {
                InitializeComponent();

                 utils.preencherCombo(cmb_Funcionarios, dao.lista(), "idFuncionarios", "nome");
        }
        
        private void bttn_Excluir_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmb_Funcionarios.SelectedValue.ToString());
            dao.Excluir(idEscolhido);
            
            utils.preencherCombo(cmb_Funcionarios, dao.lista(), "idFuncionarios", "nome");
        }

        private void cmb_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
