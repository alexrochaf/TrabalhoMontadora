using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Models
{
    public class Usuario
    {
        public int Id { get; private set; }

        [Display(Name = "Login do Usuário")]
        public string Login { get; private set; }

        [Display(Name = "Nome Completo")]
        public string Nome { get; private set; }

        [Display(Name = "Senha do Usuário")]
        public string Senha { get; private set; }

    }
}