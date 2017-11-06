using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public class Fornecedor : Pessoa
    {
        [Display(Name = "Endereço")]
        public string Endereco { get; private set; }

        public virtual ICollection<Peca> Pecas { get; private set; }
    }
}