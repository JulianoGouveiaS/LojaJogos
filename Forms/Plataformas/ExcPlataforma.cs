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
        public ExcPlataforma()
        {
            InitializeComponent();
            Utilitarios utils = new Utilitarios();
            utils.preencherCombo(cmbPlat, this.GetPlataformas(), "idPlataformas", "nome");
        }

        private void cmbPlat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public DataTable GetPlataformas()
        {
            ConnectionFactory connection = new ConnectionFactory();
            connection.Conectar();
            MySqlCommand cmd = new MySqlCommand();

            DataTable data = new DataTable("plataformas");
            cmd.Connection = connection.getConnection();
            cmd.CommandText = "SELECT idPlataformas, nome FROM plataformas ORDER BY idPlataformas";
            data.Load(cmd.ExecuteReader());
            return data;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
