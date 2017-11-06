using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public class PecaDoVeiculo
    {
        private Veiculo _veiculo = null;
        public PecaDoVeiculo(Veiculo veiculo)
        {
            _veiculo = veiculo;
        }

        [Display(Name = "Desconto")]
        public decimal Desconto { get; private set; }

        public int Id { get; private set; }

        public int PecaId { get; private set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; private set; }
    }
}