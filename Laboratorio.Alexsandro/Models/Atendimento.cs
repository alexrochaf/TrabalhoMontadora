using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Alexsandro.Models
{
    public class Atendimento
    {
        public int id { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Status { get; set; }
        public double ValorAPagar { get; set; }
        public Paciente Paciente { get; set; }
        public IList<ExamesDoAtendimento> ExamesDoAtendimentos { get; set; }

        public Atendimento()
        {
            ExamesDoAtendimentos = new List<ExamesDoAtendimento>();
            Paciente = new Paciente();
        }
    }
}