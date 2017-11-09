using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Montadora.Alexsandro.Enums;
using Montadora.Alexsandro.Models;

namespace Montadora.Alexsandro.Repository
{
    public class MontadorRepository
    {
        public IList<Montador> SelecionarTodos()
        {
            IList<Montador> listaMontadores = new List<Montador>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Montadores"
            };

            SqlDataReader dr = Conexao.ExecuteSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Montador montador = new Montador();

                    montador.Cpf = dr["cpf"].ToString();
                    montador.Nome = dr["nome"].ToString();
                    montador.Id = (int)dr["montadorID"];
                    montador.Salario = (decimal)dr["salario"];

                    listaMontadores.Add(montador);
                }

                return listaMontadores;
            }

            return null;
        }

        public void Inserir(Montador montador)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Montadores (nome, cpf, salario,) VALUES (@nome, @cpf, @salario)";

            comando.Parameters.AddWithValue("@nome", montador.Nome);
            comando.Parameters.AddWithValue("@cpf", montador.Cpf);
            comando.Parameters.AddWithValue("@salario", montador.Salario);

            var id = Conexao.ExecutarCrud(comando);
        }

        public void Atualizar(Montador montador)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Montadores SET nome=@nome, cpf=@cpf, salario=@salario WHERE montadorID = @id";

            comando.Parameters.AddWithValue("@id", montador.Id);
            comando.Parameters.AddWithValue("@nome", montador.Nome);
            comando.Parameters.AddWithValue("@cpf", montador.Cpf);
            comando.Parameters.AddWithValue("@salario", montador.Salario);

            Conexao.ExecutarCrud(comando);
        }

        public void Deletar(int id)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "DELETE FROM Montadores WHERE montadorID = @id"
            };
            comando.Parameters.AddWithValue("@id", id);

            Conexao.ExecutarCrud(comando);
        }
    }
}