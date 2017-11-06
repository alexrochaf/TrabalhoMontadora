using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Montadora.Alexsandro.Enums;
using Montadora.Alexsandro.Repository;

namespace Montadora.Alexsandro.Models
{
    public class Cidade
    {
        public int Id { get;set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public virtual EEstado Estado { get; set; }

        public IEnumerable<Cidade> GetAll()
        {
            return new CidadeRepository().BuscarTodos();
        }

        public void Add(Cidade cidade)
        {
            if (this.Id == 0)
            {
                new CidadeRepository().Inserir(cidade);
            }
            else
            {
                new CidadeRepository().Atualizar(cidade);
            }
            
        }

        public void Delet(int id)
        {
            new CidadeRepository().Deletar(id);
        }
    }
}