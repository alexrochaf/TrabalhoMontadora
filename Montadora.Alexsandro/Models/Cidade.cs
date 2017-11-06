using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Montadora.Alexsandro.Enums;

namespace Montadora.Alexsandro.Models
{
    public class Cidade
    {
        public int Id { get; private set; }

        [Display(Name = "Nome")]
        public string Nome { get; private set; }

        public virtual Estado Estado { get; private set; }

    }
}