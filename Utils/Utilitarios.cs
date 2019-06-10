using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.Utils
{
   public class Utilitarios
    {
        public void preencherCombo(ComboBox cb, DataTable data, string valueMember, string displayMember) {
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.DataSource = data;
            cb.ValueMember = valueMember;
            cb.DisplayMember = displayMember;
            cb.Update();
        }

        public void lista(string tabela, DataGridView dataGrid, string VarOrdenacao )
        {
            ConnectionFactory connection = new ConnectionFactory();
            try
            {
                DataSet conexaoDataset = new DataSet();
                connection.Conectar();
                MySqlDataAdapter conexaoAdapter = new MySqlDataAdapter("SELECT * FROM " + tabela + " ORDER BY " + VarOrdenacao, connection.getConnection());
                conexaoAdapter.Fill(conexaoDataset, tabela);
                dataGrid.DataSource = conexaoDataset;
                dataGrid.DataMember = tabela;
            }
            catch
            {
                MessageBox.Show("Impossível estabelecer conexão");
                connection.Close();
            }

        }

    }
}
