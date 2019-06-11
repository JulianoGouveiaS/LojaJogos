using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Cliente
    {
        private int id;
        private Int64 telefone;
        private string nome;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Int64 Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
