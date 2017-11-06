using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public class Cliente : Pessoa
    {
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; private set; }

        [Display(Name = "Endereço")]
        public string Endereco { get; private set; }

        [Display(Name = "Número")]
        public string Numero { get; private set; }

        [Display(Name = "RG")]
        public string Rg { get; private set; }

        [Display(Name = "Orgão Expedidor")]
        public string OrgaoExpedidor { get; private set; }
    }
}