using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    public class Jogo
    {
        private string id;
        private string idPlataforma;
        private string preco;
        private string nome;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string IdPlataforma
        {
            get { return idPlataforma; }
            set { idPlataforma = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
