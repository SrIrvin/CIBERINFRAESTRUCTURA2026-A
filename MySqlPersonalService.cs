using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CIBERINFRAESTRUCTURA
{
    public class MySqlPersonalService : IPersonalService
    {
        public List<Personal> GetAll(string connectionString)
        {
            var list = new List<Personal>();
            
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nombre, apellido, email, telefono, cargo, fecha_contratacion, activo FROM cat_personal";
                
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Personal
                            {
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                Email = reader.GetString("email"),
                                Telefono = reader.GetString("telefono"),
                                Cargo = reader.GetString("cargo"),
                                FechaContratacion = reader.GetDateTime("fecha_contratacion"),
                                Activo = reader.GetBoolean("activo")
                            });
                        }
                    }
                }
            }
            return list;
        }
    }
}
