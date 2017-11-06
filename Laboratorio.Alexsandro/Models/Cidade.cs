using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Laboratorio.Alexsandro.Enum;
using Laboratorio.Alexsandro.Repository;

namespace Laboratorio.Alexsandro.Models
{
    public class Cidade
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Cidade")]
        public string Nome { get; set; }

        [DisplayName("UF")]
        public EEstado Estado { get; set; }


        public IList<Cidade> GetAll()
        {

            return new CidadeRepository().SelecionarTodos();
        }

        public void Save()
        {
            if (this.Id == 0)
            {
                new CidadeRepository().Insert(this);

            }
            else
            {
                new CidadeRepository().Update(this);
            }

        }

        public Cidade GetById(int id)
        {
            return new CidadeRepository().SelecionarPorId(id);
        }

        public void Delete(int id)
        {
            new CidadeRepository().Delete(id);
        }
    }
}