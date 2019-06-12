using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    public class Jogo
    {
        private int id;
        private int idPlataforma;
        private double preco;
        private string nome;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int IdPlataforma
        {
            get { return idPlataforma; }
            set { idPlataforma = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
