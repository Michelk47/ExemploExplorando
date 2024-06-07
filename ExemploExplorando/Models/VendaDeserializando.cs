﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class VendaDeserializando
    {
        public int Id { get; set; }
        public string Produto { get; set;}
        public decimal Preco { get; set;}
        public DateTime DataVenda { get; set; }
    }
}
