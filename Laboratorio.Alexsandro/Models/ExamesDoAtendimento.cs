using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio.Alexsandro.Models
{
    public class ExamesDoAtendimento
    {
        public int Id { get; set; }
        public DateTime DataExame { get; set; }
        public string Status { get; set; }
        public Atendimento Atendimento { get; set; }
        public Exame Exame { get; set; }

        public ExamesDoAtendimento(Atendimento atendimento)
        {
            Exame = new Exame();
            Atendimento = atendimento;
        }
    }
}