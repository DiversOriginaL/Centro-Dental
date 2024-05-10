using Login.DataAccess.DataAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace DataAccess.DataAccess
{
    public class CdReporte:ConnectionToSql
    {
        //DIARIO
        ArrayList horas = new ArrayList();
        ArrayList ingresoDiario = new ArrayList();

        public void IngresoDiario()
        {
            using (var conexion = GetConnection())
            {
                horas.Clear();
                ingresoDiario.Clear();

                conexion.Open();
                using (SqlCommand command = new SqlCommand("IngresoDiario", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            horas.Add(reader.GetInt32(0));
                            ingresoDiario.Add(reader.GetDecimal(1));
                        }
                    }

                }
            }
        }
        public ArrayList getHoras()
        {
            return horas;
        }
        public ArrayList getIngresoDiario()
        {
            return ingresoDiario;
        }

        //SEMANAL
        ArrayList dias = new ArrayList();
        ArrayList ingresoSemanal = new ArrayList();

        public void IngresoSemanal()
        {
            using (var conexion = GetConnection())
            {
                dias.Clear();
                ingresoSemanal.Clear();

                conexion.Open();
                using (SqlCommand command = new SqlCommand("IngresoSemanal", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dias.Add(reader.GetInt32(0));
                            ingresoSemanal.Add(reader.GetDecimal(1));
                        }
                    }

                }
            }
        }
        public ArrayList getDias()
        {
            return dias;
        }
        public ArrayList getIngresoSemanal()
        {
            return ingresoSemanal;
        }

        //MENSUAL
        ArrayList semanas = new ArrayList();
        ArrayList ingresoMensual = new ArrayList();
        public void IngresoMensual()
        {
            semanas.Clear();
            ingresoMensual.Clear();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("IngresoMensual", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            semanas.Add(reader.GetInt32(0));
                            ingresoMensual.Add(reader.GetDecimal(1));
                        }
                    }

                }
            }
        }
        public ArrayList getSemanas()
        {
            return semanas;
        }
        public ArrayList getIngresoMensual()
        {
            return ingresoMensual;
        }

        //ANUAL
        ArrayList meses = new ArrayList();
        ArrayList ingresoAnual = new ArrayList();
        public void IngresoAnual()
        {
            meses.Clear();
            ingresoAnual.Clear();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("IngresoAnual", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            meses.Add(reader.GetInt32(0));
                            ingresoAnual.Add(reader.GetDecimal(1));
                        }
                    }

                }
            }
        }
        public ArrayList getMeses()
        {
            return meses;
        }
        public ArrayList getIngresoAnual()
        {
            return ingresoAnual;
        }

        //ANUALES
        ArrayList años = new ArrayList();
        ArrayList ingresosAnuales = new ArrayList();
        public void IngresosAnuales()
        {
            años.Clear();
            ingresosAnuales.Clear();

            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (SqlCommand command = new SqlCommand("IngresosAnuales", conexion))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            años.Add(reader.GetInt32(0));
                            ingresosAnuales.Add(reader.GetDecimal(1));
                        }
                    }

                }
            }
        }

        public ArrayList getAño()
        {
            return años;
        }

        public ArrayList getIngresosAnuales()
        {
            return ingresosAnuales;
        }

    }
}
