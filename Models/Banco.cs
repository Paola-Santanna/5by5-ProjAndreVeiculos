﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Banco
    {
        [Key]
        public string cnpj {  get; set; }
        public string NomeBanco { get; set; }
        public DateTime DataFundacao { get; set; }
    }
}
