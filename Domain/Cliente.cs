using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Cliente
    {
        private Int64 telefone;
        private string nome;

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
