using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Jogos;
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

namespace LojadeJogo.Forms.Jogo
{
    public partial class ExcJogo : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOJogos daoJogos = new DAOJogos();
        DataTable tabela = new DataTable();
        Utilitarios utilitarios = new Utilitarios();
        Domain.Jogo jogo = new Domain.Jogo();

        public ExcJogo()
        {
            InitializeComponent();
     //       tabela = daoJogos.lista();
            this.preencheCombo();
 //           utilitarios.preencherCombo(comboBox_Jogos, tabela, "idJogos", "nome");
            
            
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string idEscolhido = comboBox_Jogos.SelectedValue.ToString();
            daoJogos.Excluir(idEscolhido);
            this.preencheCombo();
            
        }

        private async void preencheCombo()
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("plataforma");
            dt.Columns.Add("preco");

            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countJogos");

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

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Jogos/" + i);
                    Domain.Jogo obj2 = resp2.ResultAs<Domain.Jogo>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["plataforma"] = obj2.IdPlataforma;
                    row["preco"] = obj2.Preco;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            comboBox_Jogos.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Jogos.DataSource = dt;
            comboBox_Jogos.ValueMember = "id";
            comboBox_Jogos.DisplayMember = "nome";
            comboBox_Jogos.Update();
        }
    }
}
