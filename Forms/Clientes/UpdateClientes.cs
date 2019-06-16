﻿using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.DAO.Clientes;
using LojadeJogo.DAO.Plataformas;
using LojadeJogo.Domain;
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

namespace LojadeJogo.Forms.Clientes
{
    public partial class UpdateClientes : Form
    {
        Utilitarios utils = new Utilitarios();
        DAOClientes dao = new DAOClientes();


        public UpdateClientes()
        {
            InitializeComponent();

           this.preencheCombo();
        }

        private void cmbPlataformas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idEscolhido = cmbClientes.SelectedValue.ToString();

            dao.BuscarPorId(idEscolhido, txtId, txtNome, txt_tel);
          
            txtNome.Enabled = true;
            txt_tel.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente clienteEscolhido = new Cliente();
            clienteEscolhido.Id = txtId.Text;
            clienteEscolhido.Nome = txtNome.Text;
            clienteEscolhido.Telefone = txt_tel.Text;
            dao.Editar(clienteEscolhido);

            txtId.Enabled = false;
            txtNome.Enabled = false;
            txt_tel.Enabled = false;
            this.preencheCombo();
        }

        private async void preencheCombo()
        {


            IFirebaseClient client;

            ConnectionFactory connection = new ConnectionFactory();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nome");
            dt.Columns.Add("telefone");
            client = connection.getClient();
            //parametro pro while
            int i = 0;

            //limpa a tabela pro refresh, pra nao ficar acumulando
            dt.Rows.Clear();

            //pega a referencia pro contador
            FirebaseResponse resp1 = await client.GetTaskAsync("Counter/countClientes");

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

                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/Clientes/" + i);
                    Cliente obj2 = resp2.ResultAs<Cliente>();

                    DataRow row = dt.NewRow();
                    row["id"] = obj2.Id;
                    row["nome"] = obj2.Nome;
                    row["telefone"] = obj2.Telefone;

                    dt.Rows.Add(row);

                }
                catch (Exception ex)
                {
                    //    MessageBox.Show(ex.Message);
                }
            }

            cmbClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClientes.DataSource = dt;
            cmbClientes.ValueMember = "id";
            cmbClientes.DisplayMember = "nome";
            cmbClientes.Update();
        }
    }
}
