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
    public partial class ListaFuncionarios : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOFuncionarios dao = new DAOFuncionarios();
        DataSet conexaoDataset = new DataSet();

        public ListaFuncionarios()
        {
            InitializeComponent();
            utils.lista("funcionarios", dataGridView1, "idFuncionarios");
        }
    }
}
