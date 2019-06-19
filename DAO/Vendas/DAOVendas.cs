using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Jogos;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojadeJogo.DAO.Vendas
{
    class DAOVendas
    {

        ConnectionFactory connection = new ConnectionFactory();
        DAOJogos daoJogos = new DAOJogos();
        DAOClientes daoClientes = new DAOClientes();
        DAOFuncionarios daoFunc= new DAOFuncionarios();
        IFirebaseClient client;


        public async void salvar(Venda venda)
        {

            try
            {
                this.client = connection.getClient();

                FirebaseResponse resp = await client.GetAsync("Counter/countVendas");

                FirebaseResponse respBackup = await client.GetAsync("Counter/countBackup");

                Counter_class get = resp.ResultAs<Counter_class>();

                Counter_class get2 = respBackup.ResultAs<Counter_class>();



                var venda2 = new Venda
                {
                    Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                    Descricao = venda.Descricao,
                    IdCliente = venda.IdCliente,
                    IdFuncionario = venda.IdFuncionario,
                    IdJogo = venda.IdJogo,
                    Valor = venda.Valor,
                };

                SetResponse response = await client.SetAsync("Information/Vendas/" + venda2.Id, venda2);
                SetResponse response2 = await client.SetAsync("Information/Backup/" + (Convert.ToInt32(get2.cnt) + 1).ToString(), venda2);

                Venda result = response.ResultAs<Venda>();

                MessageBox.Show("Venda enviado com sucesso");


                var obj = new Counter_class
                {
                    cnt = venda2.Id
                };

                SetResponse response1 = await client.SetAsync("Counter/countVendas", obj);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo o inesrt!!");
            }
        }

        public async void Excluir(string id)
        {
            try
            {
                this.client = connection.getClient();
                FirebaseResponse response = await client.DeleteAsync("Information/Vendas/" + id);
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                FirebaseResponse resp = await client.GetAsync("Counter/countVendas");

                Counter_class get = resp.ResultAs<Counter_class>();
                var obj = new Counter_class
                {
                    cnt = (Convert.ToInt32(get.cnt) - 1).ToString()
                };
                SetResponse response1 = await client.SetAsync("Counter/countVendas", obj);

            }


        }

        public async void Editar(Venda venda)
        {
            FirebaseResponse resp = await client.GetAsync("Information/Vendas/" + venda.Id);

            Venda get = resp.ResultAs<Venda>();
            var obj = new Venda
            {
                Descricao = venda.Descricao,
                Id = venda.Id,
                Valor = venda.Valor,
                IdJogo = venda.IdJogo,
                IdFuncionario = venda.IdFuncionario,
                IdCliente = venda.IdCliente
            
            };
            SetResponse response1 = await client.SetAsync("Information/Vendas/" + venda.Id, obj);
            MessageBox.Show("Sucesso");

        }

        public async void BuscarPorId(string id, TextBox txtDesc, TextBox txtId, TextBox txtValor, ComboBox cbJogo, ComboBox cbFunc, ComboBox cbCli)
        {
            this.client = connection.getClient();
            FirebaseResponse response = await client.GetAsync("Information/Vendas/" + id);

            Venda obj = response.ResultAs<Venda>();
            daoClientes.preencheComboById(cbCli, obj.IdCliente);
            daoFunc.preencheComboById(cbFunc, obj.IdFuncionario);
            daoJogos.preencheComboById(cbJogo, obj.IdJogo);


            txtDesc.Text = obj.Descricao;
            txtId.Text = obj.Id;
            txtValor.Text = obj.Valor;

        }


        public async void preencheCombo(ComboBox cmb)
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("descricao");
            dt.Columns.Add("valor");
            dt.Columns.Add("cliente");
            dt.Columns.Add("jogo");


            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetAsync("Counter/countVendas");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Vendas/" + i);
                    Domain.Venda obj2 = resp2.ResultAs<Domain.Venda>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["descricao"] = obj2.Descricao;
                    row["valor"] = obj2.Valor;
                    row["cliente"] = obj2.IdCliente;
                    row["jogo"] = obj2.IdJogo;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "descricao";
            cmb.Update();
        }

        public async void preencheComboById(ComboBox cmb, string id)
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("descricao");
            dt.Columns.Add("valor");
            dt.Columns.Add("cliente");
            dt.Columns.Add("jogo");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetAsync("Counter/countVendas");

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

                    FirebaseResponse resp2 = await client.GetAsync("Information/Vendas/" + i);
                    Venda obj2 = resp2.ResultAs<Venda>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["descricao"] = obj2.Descricao;
                    row["valor"] = obj2.Valor;
                    row["cliente"] = obj2.IdCliente;
                    row["jogo"] = obj2.IdJogo;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.DataSource = dt;
            cmb.ValueMember = "id";
            cmb.DisplayMember = "nome";
            cmb.SelectedValue = id;
            cmb.Update();
        }

    }
}
