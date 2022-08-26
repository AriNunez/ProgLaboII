using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = "Data Source =.; Initial Catalog=EMPRESA_DB; Integrated Security = True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();

                command.CommandText = "SELECT NOMBRE,ID_EMPLEADO FROM EMPLEADOS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["ID_EMPLEADO"])));
                    }
                }

                return personas;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close(); 
            }

        }        
        public static List<Persona> Guardar()
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();

                command.CommandText = "INSERT INTO NOMBRE,ID_EMPLEADO FROM EMPLEADOS";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["NOMBRE"].ToString(), Convert.ToInt32(dataReader["ID_EMPLEADO"])));
                    }
                }

                return personas;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close(); 
            }

        }

        public static void Eliminar(int id)
        {
            try
            {
                connection.Open();
                command.CommandText = "DELETE ";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
