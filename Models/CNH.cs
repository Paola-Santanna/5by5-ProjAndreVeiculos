﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CNH
    {

        public long Id { get; set; }
        public DateTime DataVencimento { get; set; }
        public string Rg {  get; set; }
        public string Cpf {  get; set; }
        public string NomeMae {  get; set; }
        public string NomePai {  get; set; }
        public Categoria Categoria { get; set; }
        
    }
}
