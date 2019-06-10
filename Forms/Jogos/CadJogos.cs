using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LojadeJogo.Domain;

namespace LojadeJogo.Forms.Jogos
{
    public partial class CadJogos : Form
    {
        public CadJogos()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox_Plataforma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo();
            jogo.nome = txt_nome.Text;
            jogo.preco = double.Parse(txt_preco.Text.ToString());
            
            
        }
    }
}
