﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojadeJogo.Domain
{
     public class Plataforma {
        public string id;

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Id    
        {
            get { return id; }
            set { id = value; }
        }
    }
    
}
