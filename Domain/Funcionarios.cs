using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo
{
    class Funcionario
    {
        public string id;
        private string salario;
        private string nome;

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Salario {
            get { return salario; }
            set { salario = value; }
        }

    }
}
