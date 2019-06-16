using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Usuario
    {
        private string id;
        private string senha;
        private string nome;
        private string isAdm;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string IsAdm
        {
            get { return isAdm; }
            set { isAdm = value; }
        }

    }
}
