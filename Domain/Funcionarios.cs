using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo
{
    class Funcionario
    {
        public int id;
        private double salario;
        private string nome;

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public double Salario {
            get { return salario; }
            set { salario = value; }
        }

    }
}
