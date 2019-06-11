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
    public partial class ExcFuncionarios : Form
    {
        public ExcFuncionarios()
        {
            Utilitarios utils = new Utilitarios();
            DAOFuncionarios dao = new DAOFuncionarios();

            public ExcFuncionarios()
            {
                InitializeComponent();
                utils.preencherCombo(cmb_Func, dao.lista(), "idFuncionarios", "nome");
            }
        }
    }
}
