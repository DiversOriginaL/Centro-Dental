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
        public DataTable mostrarPacientes()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("mostrarPacientes", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader leer = command.ExecuteReader())
                    {
                        dt.Load(leer);
                    }
                }
            }
            return dt;
        }

        public void InsertarPaciente(Paciente paciente, Contactos contacto, Ubicaciones ubicacion, EstadoSalud estado)
        {
            using (SqlConnection conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("insertarPacientes", conexion))
                {
                    if (paciente != null)
                    {
                        try
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            // Verificar si los valores no son nulos antes de usarlos
                            string pnombre = paciente.GetPNombre() ?? "";
                            string snombre = paciente.GetSNombre() ?? "";
                            string papellido = paciente.GetPApellido() ?? "";
                            string sapellido = paciente.GetSApellido() ?? "";
                            string edad = paciente.GetEdad() ?? "";
                            char sexo = paciente.GetSexo();
                            string celular = contacto.GetCelular() ?? "";
                            string telefono = contacto.GetTelefono() ?? "";
                            string ciudad = ubicacion.GetCiudad() ?? "";
                            string sector = ubicacion.GetSector() ?? "";
                            string calle = ubicacion.GetCalle() ?? "";
                            string numcasa = ubicacion.GetNumCasa() ?? "";
                            string enfermedad = estado.GetEnfermedad() ?? "";
                            string medicamento = estado.GetMedicamento() ?? "";
                            string alergia = estado.GetAlergia() ?? "";
                            string embarazo = estado.GetEmbarazo() ?? "";

                            command.Parameters.AddWithValue("@PNombre", pnombre.Trim());
                            command.Parameters.AddWithValue("@SNombre", snombre.Trim());
                            command.Parameters.AddWithValue("@PApellido", papellido.Trim());
                            command.Parameters.AddWithValue("@SApellido", sapellido.Trim());
                            command.Parameters.AddWithValue("@Edad", edad.Trim());
                            command.Parameters.AddWithValue("@Sexo", sexo);
                            command.Parameters.AddWithValue("@Celular", celular.Trim());
                            command.Parameters.AddWithValue("@Telefono", telefono.Trim());
                            command.Parameters.AddWithValue("@Ciudad", ciudad.Trim());
                            command.Parameters.AddWithValue("@Sector", sector.Trim());
                            command.Parameters.AddWithValue("@Calle", calle.Trim());
                            command.Parameters.AddWithValue("@NumCasa", numcasa.Trim());
                            command.Parameters.AddWithValue("@Enfermedad", enfermedad.Trim());
                            command.Parameters.AddWithValue("@Medicamento", medicamento.Trim());
                            command.Parameters.AddWithValue("@Alergia", alergia.Trim());
                            command.Parameters.AddWithValue("@Embarazo", embarazo.Trim());
                            command.ExecuteNonQuery();
                            command.Parameters.Clear();
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine("\nError: " + ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ha ocurrido un error.");
                    }
                }
            }
        }

    }
}
