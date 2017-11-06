using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Laboratorio.Alexsandro.Enum;
using Laboratorio.Alexsandro.Models;

namespace Laboratorio.Alexsandro.Repository
{
    public class CidadeRepository
    {
        public IList<Cidade> SelecionarTodos()
        {
            IList<Cidade> listaCidade = new List<Cidade>();


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
                    //cidade.Estado = (EEstado) System.Enum.Parse(typeof(EEstado), dr["estado"].ToString());
                    cidade.Nome = (string)dr["nome"];
                    cidade.Id = (int)dr["cidadeId"];

                    listaCidade.Add(cidade);
                }
                return listaCidade;
            }
            return null;
        }

        public Cidade SelecionarPorId(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Cidades WHERE cidadeId = @id";
            comando.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = Conexao.ExecuteSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                return new Cidade
                {
                    Estado = (EEstado)dr["estado"],
                    Nome = (string)dr["nome"],
                    Id = (int)dr["cidadeId"]
                };

            }
            return null;
        }

        public void Insert(Cidade cidade)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Cidades (nome, estado) VALUES (@nome, @estado), SELECT CAST(SCOPE_IDENTITY() AS INT)";

            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@estado", cidade.Estado);

            var id = Conexao.ExecutarCrud(comando);
        }

        public void Update(Cidade cidade)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "UPDATE Cidades SET nome = @nome, estado = @estado WHERE cidadeId = @id";

            comando.Parameters.AddWithValue("@nome", cidade.Nome);
            comando.Parameters.AddWithValue("@estado", cidade.Estado);
            comando.Parameters.AddWithValue("@id", cidade.Id);

            Conexao.ExecutarCrud(comando);
        }

        public void Delete(int id)
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