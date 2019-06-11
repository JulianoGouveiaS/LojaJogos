using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Jogo
    {
        public int idJogo { get; set; }
        public String nome { get; set; }
        public double preco { get; set; }
        public int idPlataforma { get; set; }
    }
}
