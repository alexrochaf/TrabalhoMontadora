using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Laboratorio.Alexsandro.Repository
{
    public class Conexao
    {
        private static SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["BD_Laboratorio"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            return conexao;
        }

        public static int ExecutarCrud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            int id = Convert.ToInt16(comando.ExecuteScalar());
            con.Close();
            return id;
        }

        public static SqlDataReader ExecuteSelect(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            return comando.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}