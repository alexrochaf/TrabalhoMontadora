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
    public class CidadeRepository
    {
        public IList<Cidade> BuscarTodos()
        {
            IList<Cidade> listaCidades = new List<Cidade>();

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Cidades"
            };

            SqlDataReader dr = Conexao.ExecuteSelect(comando);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Cidade cidade = new Cidade();

                    cidade.Estado = (EEstado)dr["estado"];
                    cidade.Nome = dr["nome"].ToString();
                    cidade.Id = (int) dr["cidadeId"];

                    listaCidades.Add(cidade);
                }

                return listaCidades;
            }

            return null;
        }


        public void Inserir(Cidade cidade)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cidades (nome, estado) VALUES (@nome, @estado)";

            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@estado", cidade.Estado);

            var id = Conexao.ExecutarCrud(comando);
        }

        public void Atualizar(Cidade cidade)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Cidades SET nome = @nome, estado = @estado WHERE cidadeId = @id";

            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@estado", cidade.Estado);
            comando.Parameters.AddWithValue("@id", cidade.Id);

            Conexao.ExecutarCrud(comando);
        }

        public void Deletar(int id)
        {
            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = "DELETE FROM Cidades WHERE cidadeId = @id"
            };
            comando.Parameters.AddWithValue("@id", id);

            Conexao.ExecutarCrud(comando);
        }
    }
}