using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Laboratorio.Alexsandro.Enum;
using Laboratorio.Alexsandro.Repository;

namespace Laboratorio.Alexsandro.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nome { get; set; }
        public PlanoSaude PlanoSaude { get; set; }
        public ETipoConveniado TipoConveniado { get; set; }
        public Cidade Cidade { get; set; }

        public IList<Paciente> GetForName(string nome)
        {
            return new PacienteRepository().SelecionarPorNome(nome);
        }
    }
}