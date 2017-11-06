using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Montadora.Alexsandro.Repository
{
    public class Conexao
    {
        private static SqlConnection Conectar()
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            SqlConnection conexao = new SqlConnection(stringConexao);
            conexao.Open();

            return conexao;
        }

        public static int ExecutarCrud(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            //int id = Convert.ToInt16(comando.ExecuteScalar());
            con.Close();
            return 0;
        }

        public static SqlDataReader ExecuteSelect(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            return comando.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}