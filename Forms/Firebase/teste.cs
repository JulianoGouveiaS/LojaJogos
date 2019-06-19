using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace LojadeJogo.Forms.Firebase
{
    public partial class teste : Form
    {

        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "sVHBJ1TEcUkTCyWYwT30UDo5O8LAtuxbeGhpEpRb",
            BasePath = "https://loja-jogos-68e8d.firebaseio.com/"
        };

        IFirebaseClient client;


        public teste()
        {
            InitializeComponent();
        }

        private void teste_Load(object sender, EventArgs e)
        {

            //cria instancia do cliente do firebase
            client = new FireSharp.FirebaseClient(config);
            if (client != null) {
            }

            //adiciona as colunas na datagrid
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("endereco");
            dt.Columns.Add("idade");

            dataGridView1.DataSource = dt;

        }

        private async void btn_insert_Click(object sender, EventArgs e)
        {
            //cria instancia para o repositorio
            FirebaseResponse resp = await client.GetAsync("Counter/node");

            //pega os dados de acordo com o tipo de classe que queremos
            //no caso pegamos a variavel count dos ids
            Counter_class get = resp.ResultAs<Counter_class>();
           
            //inserir
            
            //popula a classe com os dados que queremos inserir
            //eu criei a classe Data, mas poderia ser qqr coisa (tipo Funcionario, CLiente, Plataforma, etc)
            var data = new Data
            {
                //seta o id como a variavel que ja tinha + 1
                Id = (Convert.ToInt32(get.cnt)+1).ToString(),
                Nome = txt_nome.Text,
                Endereco = txt_endereco.Text,
                Idade = txt_idade.Text

            };

            //seta a classe que populamos em determinado repositorio
            //no caso setamos a var data em Information/{id dela}
            SetResponse response = await client.SetAsync("Information/"+data.Id, data);

            //pega o resultado
            Data result = response.ResultAs<Data>();

            MessageBox.Show(result.Nome + " enviado com sucesso");

            //cria um novo objeto de contagem, com o valor do id da classe inserida anteriormente
            
            var obj = new Counter_class {
                cnt = data.Id
            };

            //atualiza a contagem 
            SetResponse response1 = await client.SetAsync("Counter/node", obj);
    
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //retornar

            //cria instancia para o repositorio com o id desejado
            FirebaseResponse response = await client.GetAsync("Information/"+txt_id.Text);

            //pega o objeto 
            Data obj = response.ResultAs<Data>();

            //coloca os dados do obj buscado e coloca  nos texts
            txt_id.Text = obj.Id;
            txt_nome.Text = obj.Nome;
            txt_endereco.Text = obj.Endereco;
            txt_idade.Text = obj.Idade;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //atualizar

            //popula a classe com os dados que queremos atualizar
            var data = new Data
            {
                Id=txt_id.Text,
                Nome=txt_nome.Text,
                Idade=txt_idade.Text,
                Endereco=txt_endereco.Text
            };

            //pega a instancia do repositorio de acordo com o id que queremos atualizar e colocamos a variavel que queremos
            //colocar no lugar dela
            FirebaseResponse response = await client.UpdateAsync("Information/"+txt_id.Text, data);

            //pega o resultado do update
            Data result = response.ResultAs<Data>();

            MessageBox.Show("id " + result.Id + " atualizado");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            //deletar

            //da um delete no repositorio de acordo com id
            FirebaseResponse response = await client.DeleteAsync("Information/" + txt_id.Text);

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            //deletar todos


            //da um delete no repositorio 
            FirebaseResponse response = await client.DeleteAsync("Information");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            export();
        }

        private async void export()
        {
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetAsync("Counter/node");
            
            //coloca o conteudo da referencia na variavel do tipo Counter_class que eu criei
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            //criei a var cnt e coloquei o valor de contagem que busquei do firebase
            int cnt = Convert.ToInt32(obj1.cnt);

            while (true) {
                //while ate rodar todos os objetos, pois cnt vai estar representando quantos cadastros ja existem
                if (i == cnt) {
                    break;
                }
                i++;
                try
                {
                  
                    FirebaseResponse resp2 = await client.GetAsync("Information/"+i);
                    Data obj2 = resp2.ResultAs<Data>();

                    DataRow row = dt.NewRow();

                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["endereco"] = obj2.Endereco;
                    row["idade"] = obj2.Idade;

                    dt.Rows.Add(row);

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
