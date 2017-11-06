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
    public class PacienteRepository
    {
        public IList<Paciente> SelecionarPorNome(string nome)
        {
            IList<Paciente> listaPaciente = new List<Paciente>();

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM Paciente WHERE Nome Like @nome";
            comando.Parameters.AddWithValue("@nome", "%"+nome+"%");
            SqlDataReader dr = Conexao.ExecuteSelect(comando);

            if (dr.HasRows)
            {
                dr.Read();
                {
                    Paciente paciente = new Paciente();

                    paciente.Cidade = new Cidade().GetById((int) dr["cidadeId"]);
                    paciente.Nome = (string) dr["nome"];
                    paciente.Id = (int) dr["cidadeId"];
                    paciente.TipoConveniado = (ETipoConveniado) dr["tipoConveniado"];

                    listaPaciente.Add(paciente);
                };
                return listaPaciente;
            }
            return null;
        }
    }
}