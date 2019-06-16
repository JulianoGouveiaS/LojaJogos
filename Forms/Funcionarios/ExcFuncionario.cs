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
    public partial class ExcFuncionario : Form
    {

        Utilitarios utils = new Utilitarios();
        DAOFuncionarios dao = new DAOFuncionarios();

        
            public ExcFuncionario()
            {
                InitializeComponent();

            //     utils.preencherCombo(cmb_Funcionarios, dao.lista(), "idFuncionarios", "nome");
            this.preencheCombo();
        }
        
        private void bttn_Excluir_Click(object sender, EventArgs e)
        {
            int idEscolhido = int.Parse(cmb_Funcionarios.SelectedValue.ToString());
            dao.Excluir(idEscolhido);

            this.preencheCombo();
        }

        private void cmb_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void preencheCombo()
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("salario");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countFuncionarios");

            //coloca o conteudo da referencia na variavel do tipo Counter_class que eu criei
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            //criei a var cnt e coloquei o valor de contagem que busquei do firebase
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Funcionarios/" + i);
                    Funcionario obj2 = resp2.ResultAs<Funcionario>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["salario"] = obj2.Salario;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmb_Funcionarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Funcionarios.DataSource = dt;
            cmb_Funcionarios.ValueMember = "id";
            cmb_Funcionarios.DisplayMember = "nome";
            cmb_Funcionarios.Update();
        }
    }
}
