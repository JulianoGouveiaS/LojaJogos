using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Forms.Firebase;
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
    public partial class UpdateJogo : Form
    {
        Utils.Utilitarios utils = new Utils.Utilitarios();
        DAOJogos daoJogos = new DAOJogos();
        DaoPlataformas daoPlataformas = new DaoPlataformas();

        public UpdateJogo()
        {
            InitializeComponent();
            //   tabelaJogo = daoJogos.lista();
            //    utilitarios.preencherCombo(comboBox_jogo, tabelaJogo, "idJogos", "nome");

            this.preencheCombo();

        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            Domain.Jogo jogoEscolhido = new Domain.Jogo();
            jogoEscolhido.Id = txt_id.Text;
            jogoEscolhido.Nome = txt_nome.Text;
            jogoEscolhido.IdPlataforma = comboBox_plataforma.SelectedValue.ToString();
            jogoEscolhido.Preco = txt_Preco.Text;
            daoJogos.Editar(jogoEscolhido);

            this.preencheCombo();
        }

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            string idEscolhido = comboBox_jogo.SelectedValue.ToString();

            daoJogos.BuscarPorId(idEscolhido, txt_id, txt_nome, comboBox_plataforma, txt_Preco);
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

            comboBox_jogo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_jogo.DataSource = dt;
            comboBox_jogo.ValueMember = "id";
            comboBox_jogo.DisplayMember = "nome";
            comboBox_jogo.Update();
        }

        private void comboBox_jogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
