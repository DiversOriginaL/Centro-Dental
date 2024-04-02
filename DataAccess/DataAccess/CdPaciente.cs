using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
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
                            string pnombre = paciente.GetPNombre() ?? "SIN ESPECIFICAR";
                            string snombre = paciente.GetSNombre() ?? "SIN ESPECIFICAR";
                            string papellido = paciente.GetPApellido() ?? "SIN ESPECIFICAR";
                            string sapellido = paciente.GetSApellido() ?? "SIN ESPECIFICAR";
                            string edad = paciente.GetEdad() ?? "SIN ESPECIFICAR";
                            char sexo = paciente.GetSexo();
                            string celular = contacto.GetCelular() ?? "SIN ESPECIFICAR";
                            string telefono = contacto.GetTelefono() ?? "SIN ESPECIFICAR";
                            string provincia = ubicacion.GetProvincia() ?? "SIN ESPECIFICAR";
                            string sector = ubicacion.GetSector() ?? "SIN ESPECIFICAR";
                            string calle = ubicacion.GetCalle() ?? "SIN ESPECIFICAR";
                            string numcasa = ubicacion.GetNumCasa() ?? "SIN ESPECIFICAR";
                            int usuario = UserLoginCache.GetID();
                            string enfermedad = estado.GetEnfermedad() ?? "NO TIENE NINGUNA ENFERMEDAD";
                            string medicamento = estado.GetMedicamento() ?? "NO ESTA TOMANDO NINGUN MEDICAMENTO";
                            string alergia = estado.GetAlergia() ?? "NO ES ALERGICO A MEDICAMENTOS";
                            string embarazo = estado.GetEmbarazo() ?? "NO";

                            command.Parameters.AddWithValue("@PNombre", pnombre.Trim());
                            command.Parameters.AddWithValue("@SNombre", snombre.Trim());
                            command.Parameters.AddWithValue("@PApellido", papellido.Trim());
                            command.Parameters.AddWithValue("@SApellido", sapellido.Trim());
                            command.Parameters.AddWithValue("@Edad", edad.Trim());
                            command.Parameters.AddWithValue("@Sexo", sexo);
                            command.Parameters.AddWithValue("@Celular", celular.Trim());
                            command.Parameters.AddWithValue("@Telefono", telefono.Trim());
                            command.Parameters.AddWithValue("@Provincia", provincia.Trim());
                            command.Parameters.AddWithValue("@Sector", sector.Trim());
                            command.Parameters.AddWithValue("@Calle", calle.Trim());
                            command.Parameters.AddWithValue("@NumCasa", numcasa.Trim());
                            command.Parameters.AddWithValue("@UsuarioID", usuario);
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
