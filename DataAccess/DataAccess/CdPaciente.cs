using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Entidades;
using Login.DataAccess.DataAccess;

namespace DataAccess.DataAccess
{
    public class CdPaciente:ConnectionToSql
    {
        
        public List<Paciente> mostrarPacientes()
        {
            List<Paciente> pacientes = new List<Paciente>();

            try
            {
                using (SqlConnection conexion = GetConnection())
                {
                    conexion.Open();
                    string query = "" +
                        "SELECT PacienteID, PNombre, SNombre, PApellido, SApellido, Edad, Sexo, ContactoID, " +
                        "UbicacionID, UsuarioID, EstadoSaludID FROM Pacientes";

                    using (SqlCommand command = new SqlCommand(query, conexion))
                    {
                        command.CommandType = CommandType.Text;

                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Paciente paciente = new Paciente();
                                Contactos contacto = new Contactos();
                                Ubicaciones ubicacion = new Ubicaciones();
                                Usuario usuario = new Usuario();
                                EstadoSalud estadoSalud = new EstadoSalud();

                                paciente.Setid(Convert.ToInt32(reader.GetString(0)));
                                paciente.SetPNombre(reader.GetString(1));
                                paciente.SetSNombre(reader.GetString(2));
                                paciente.SetPApellido(reader.GetString(3));
                                paciente.SetSApellido(reader.GetString(4));
                                paciente.SetEdad(Convert.ToInt32(reader.GetString(5)));
                                paciente.SetSexo(reader.GetString(6));
                                contacto.SetContactoID(Convert.ToInt32(reader.GetString(7)));
                                ubicacion.SetUbicacionID(Convert.ToInt32(reader.GetString(8)));
                                usuario.SetUsuarioID(Convert.ToInt32(reader.GetString(9)));
                                estadoSalud.SetEstadoSaludID(Convert.ToInt32(reader.GetString(10)));

                                // Agregar el paciente a la lista
                                pacientes.Add(paciente);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al recuperar pacientes: " + ex.Message);
            }

            return pacientes;
        }

    }
}
