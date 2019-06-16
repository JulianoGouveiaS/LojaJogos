using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
    class Venda
    {
        private string id;

        private string descricao;

        private string valor;

        private string idCliente;

        private string idJogo;

        private string idFuncionario;


        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string IdJogo
        {
            get { return idJogo; }
            set { idJogo = value; }
        }

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }

        public string IdFuncionario
        {
            get { return idFuncionario; }
            set { idFuncionario = value; }
        }
    }
}
