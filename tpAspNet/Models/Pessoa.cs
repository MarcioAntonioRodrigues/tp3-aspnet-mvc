using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tpAspNet.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        [Display(Name = "Sobrenome")]
        public string SobreNome { get; set; }
        [Display(Name = "Data de aniversário")]
        public DateTime DataAniversario { get; set; }
    }
}