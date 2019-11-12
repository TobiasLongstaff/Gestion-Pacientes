using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Common.Cache;

namespace CapaDatos
{
    public class CD_Usuarios:ConnectionToSql
    {
        public bool Login(string Usuario, string Contraseña)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where Usuario=@usuario and Contraseña=@contraseña";
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@contraseña", Contraseña);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheUsuarios.Id = reader.GetInt32(0);
                            CacheUsuarios.Usuario = reader.GetString(1);
                            CacheUsuarios.Nombre = reader.GetString(2);
                            CacheUsuarios.Apellido = reader.GetString(3);
                            CacheUsuarios.Mail = reader.GetString(4);
                            CacheUsuarios.FDN = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool BuscarFicha(string NombreYApellido)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Admision where NombreYApellido=@nombreYApellido";
                    command.Parameters.AddWithValue("@nombreYApellido", NombreYApellido);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CachePacientes.ID = reader.GetInt32(0);
                            CachePacientes.HCN = reader.GetString(1);
                            CachePacientes.NombreYApellido = reader.GetString(2);
                            CachePacientes.Edad = reader.GetInt32(3);
                            CachePacientes.FechaDeNacimiento = reader.GetString(4);
                            CachePacientes.Nacionalidad = reader.GetString(5);
                            CachePacientes.DNI = reader.GetInt32(6);
                            CachePacientes.EstadoCivil = reader.GetString(7);
                            CachePacientes.Ocupacion = reader.GetString(8);
                            CachePacientes.Colegio = reader.GetString(9);
                            CachePacientes.Domicilio = reader.GetString(10);
                            CachePacientes.Localidad = reader.GetString(11);
                            CachePacientes.Telefono = reader.GetString(12);
                            CachePacientes.TelefonoAux = reader.GetString(13);
                            CachePacientes.IDObraSocial = reader.GetInt32(14);
                            CachePacientes.DerivadoPor = reader.GetString(15);
                            CachePacientes.AcompañadoPor = reader.GetString(16);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
