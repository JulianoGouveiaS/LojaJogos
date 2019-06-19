using FireSharp.Interfaces;
using FireSharp.Response;
using LojadeJogo.Domain;
using LojadeJogo.Forms.Firebase;
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

namespace LojadeJogo.Forms.Login
{
    public partial class Registrar : Form
    {
        ConnectionFactory connection = new ConnectionFactory();
        IFirebaseClient client;
        string isAdm = "0";
        public Registrar()
        {
            InitializeComponent();
        }

        private void checkAdm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAdm.Checked)
            {
               isAdm = "1";
            }
            else
            {
                isAdm = "0";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string user = txrUser.Text;
            string senha = txtSenha.Text;
            
            try { 
            this.client = connection.getClient();

            FirebaseResponse resp = await client.GetAsync("Counter/countUsuarios");

            Counter_class get = resp.ResultAs<Counter_class>();

            var user2 = new Usuario
            {
                Id = (Convert.ToInt32(get.cnt) + 1).ToString(),
                Nome = user,
                Senha = txtSenha.Text,
                IsAdm = this.isAdm

            };

            SetResponse response = await client.SetAsync("Information/Usuarios/" + user2.Id, user2);

                Usuario result = response.ResultAs<Usuario>();

            MessageBox.Show(result.Nome + " criado com sucesso");


            var obj = new Counter_class
            {
                cnt = user2.Id
            };

            SetResponse response1 = await client.SetAsync("Counter/countUsuarios", obj);
         }
            catch (MySqlException ex)
            {
                MessageBox.Show("Nao deu certo o insert!!");

            }
        }
    }
}
