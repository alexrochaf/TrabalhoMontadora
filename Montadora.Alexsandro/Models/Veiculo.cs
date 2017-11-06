using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Montadora.Alexsandro.Models
{
    public class Veiculo
    {
        [Display(Name = "Categoria")]
        public string Categoria { get; private set; }

        [Display(Name = "Marca")]
        public string Marca { get; private set; }

        [Display(Name = "Modelo")]
        public string Modelo { get; private set; }

        public int Id { get; private set; }

        [Display(Name = "Usuário")]
        public virtual Usuario Usuario { get; private set; }

        [Display(Name = "Montador")]
        public virtual Montador Montador { get; private set; }

        [Display(Name = "Cliente")]
        public virtual Cliente Cliente { get; private set; }

        [Display(Name = "Peças do Veículo")]
        public virtual ICollection<PecaDoVeiculo> PecasDoVeiculo { get; private set; }
    }
}