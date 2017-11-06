using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public class Peca
    {
        public int Id { get; private set; }

        [Display(Name = "Data de Fabricação")]
        public DateTime DataFabricacao { get; private set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }

        [Display(Name = "Número de Série")]
        public string NumeroSerie { get; private set; }

        [Display(Name = "Valor")]
        public decimal Valor { get; private set; }

        [Display(Name = "Fornecedor")]
        public virtual Fornecedor Fornecedor { get; private set; }
    }
}