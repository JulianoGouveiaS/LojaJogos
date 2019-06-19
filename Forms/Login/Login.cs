using LojadeJogo.Forms.Plataformas;
using LojadeJogo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Forms.Firebase;
using LojadeJogo.Domain;

namespace LojadeJogo.Forms.Login
{
    public partial class Login : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
            this.preencheCombo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.verificaUser();

        }

        public async void verificaUser() {

            this.client = connection.getClient();

            FirebaseResponse response = await client.GetAsync("Information/Usuarios/" + cbUsers.SelectedValue.ToString());

            Usuario obj = response.ResultAs<Usuario>();
           
           
            if (txtSenha.Text == obj.Senha.ToString())
            {
                this.Hide();
                FormPrincipal form = new FormPrincipal(obj.IsAdm);
               
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else {
                MessageBox.Show("Senha Incorreta!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar form = new Registrar();
            form.Show();
        }

        public async void preencheCombo()
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("isAdm");
            dt.Columns.Add("senha");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetAsync("Counter/countUsuarios");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Usuarios/" + i);
                    Usuario obj2 = resp2.ResultAs<Usuario>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["isAdm"] = obj2.IsAdm;
                    row["senha"] = obj2.Senha;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbUsers.DataSource = dt;
            cbUsers.ValueMember = "id";
            cbUsers.DisplayMember = "nome";
            cbUsers.Update();
        }
    }
}
