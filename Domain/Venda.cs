using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Venda
    {
        private int id;

        private string descricao;

        private double valor;

        private int idCliente;

        private int idJogo;

        private int idFuncionario;


        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdJogo
        {
            get { return idJogo; }
            set { idJogo = value; }
        }

        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public int IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
    }
}
