using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public abstract class Pessoa
    {
        public int Id { get; private set; }

        [Display(Name = "CPF")]
        public string Cpf { get; private set; }

        [Display(Name = "Nome")]
        public string Nome { get; private set; }
    }
}