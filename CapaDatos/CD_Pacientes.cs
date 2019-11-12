using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CD_Pacientes:CD_Conexion
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostarPacientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaObraSocial()
        {
            DataTable table = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListaObraSocial";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            table.Load(leer);
            conexion.CerrarConexion();
            return table;
        }

        public DataTable ListaRegistroDiario()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarRegistro";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarNombreYApellidoPaciente(string NombreYApellido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarBusquedaDePacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreYApellido", NombreYApellido);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarNombreYApellidoRegistro(string NombreYApellido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarNombre3";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreYApellido", NombreYApellido);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarNombreYApellidoAdmision(string NombreYApellido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarNombre2";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreYApellido", NombreYApellido);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable SelecionarObraSocial(int IDObraSocial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SelecionarObra1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idobrasocial", IDObraSocial);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarObraSocial()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarObrasocial1";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable BuscarEvaluaciones(string NombreDelArchivo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarEvaluacionEInformes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreDelArchivo", NombreDelArchivo);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public void insertar(string Nombre, string Apellido, int IDObraSocial, string FechaDeNacimiento, string NumeroDeAfiliado, string Telefono, int DNI )
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Pacientes values('" + Nombre + "', '" + Apellido + "', " + IDObraSocial + ", '"+ FechaDeNacimiento + "','" + NumeroDeAfiliado + "','" + Telefono + "'," + DNI + ")";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void insertarRegistroDiario(string Fecha, string Hora, string NombreYApellido, int IDPaciente, string AusenteOPresente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into RegistroDiario values('" + Fecha + "','"+ Hora +"','" + NombreYApellido + "', " + IDPaciente + ", '" + AusenteOPresente + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void InsertarPagoObraSocial(string FechaDePago, int IDObrasocial, string TotalPagado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into ControlDePagos values('" + FechaDePago + "', " + IDObrasocial + ", '" + TotalPagado + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void InsertarObraSocial(string ObrasSociales)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into ObrasSociales values('" + ObrasSociales + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void InsetarEvaluacionOInforme(string NombreDelArchivo, string DireccionDelArchivo, string TipoDeArchivo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into EvaluacionEInformes values('" + NombreDelArchivo + "','" + DireccionDelArchivo + "','" + TipoDeArchivo + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void Editar (string Nombre, string Apellido, int IDObraSocial, string FechaDeNacimiento, string NumeroDeAfiliado, string Telefono, int DNI, int ID)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPacientes1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@apellido", Apellido);
            comando.Parameters.AddWithValue("@IDObraSocial", IDObraSocial);
            comando.Parameters.AddWithValue("@FechaDeNacimiento", FechaDeNacimiento);
            comando.Parameters.AddWithValue("@NumeroDeAfiliado", NumeroDeAfiliado);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@DNI", DNI);
            comando.Parameters.AddWithValue("@id", ID);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarPacientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idusu", Id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarRegistroDiario(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarRegistroDiario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idpa", Id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EliminarObraSocial(int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarObraSocial";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdOb", Id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void AgregarCuenta (string Usuario, string Nombre, string Apellido, string Mail, string FDN, string Contraseña)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Usuarios values('" + Usuario + "','" + Nombre + "', '" + Apellido + "', '" + Mail + "', '" + FDN + "','" + Contraseña + "')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

        public void EditarPerfil(string Usuario, string Contraseña, int Id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarPerfil";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", Usuario);
            comando.Parameters.AddWithValue("@contraseña", Contraseña);
            comando.Parameters.AddWithValue("@id", Id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void EditarAdmision(string HCN, string NombreYApellido, int Edad, string FechaDeNacimiento, string Nacionalidad, int TipoYNDocumento,
            string EstadoCivil, string Ocupacino, string Colegio, string Domicilio, string Localidad, string Telefono, string TelefonoAux, int IDObraSocial,
            string DerivadoPor, string AcompañadoPor, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarFicha";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@hcn", HCN);
            comando.Parameters.AddWithValue("@nombreYApellido", NombreYApellido);
            comando.Parameters.AddWithValue("@edad", Edad);
            comando.Parameters.AddWithValue("@fechaDeNacimiento", FechaDeNacimiento);
            comando.Parameters.AddWithValue("@nacionalidad", Nacionalidad);
            comando.Parameters.AddWithValue("@tipoYNDocumento", TipoYNDocumento);
            comando.Parameters.AddWithValue("@estadoCivil", EstadoCivil);
            comando.Parameters.AddWithValue("@ocupacion", Ocupacino);
            comando.Parameters.AddWithValue("@colegio", Colegio);
            comando.Parameters.AddWithValue("@domicilio", Domicilio);
            comando.Parameters.AddWithValue("@localidad", Localidad);
            comando.Parameters.AddWithValue("@telefono", Telefono);
            comando.Parameters.AddWithValue("@telefonoAux", TelefonoAux);
            comando.Parameters.AddWithValue("@IDObraSocial", IDObraSocial);
            comando.Parameters.AddWithValue("@derivadoPor", DerivadoPor);
            comando.Parameters.AddWithValue("@acompañadoPor", AcompañadoPor);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void InsertarAdmision(string HCN, string NombreYApellido, int Edad, string FechaDeNacimiento, string Nacionalidad, int TipoYNDocumento,
            string EstadoCivil, string Ocupacino, string Colegio, string Domicilio, string Localidad, string Telefono, string TelefonoAux, int IDObraSocial,
            string DerivadoPor, string AcompañadoPor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "insert into Admision values('" + HCN + "', '" + NombreYApellido + "', " + Edad + ", '" + FechaDeNacimiento + "','" + Nacionalidad + "',"
            +TipoYNDocumento+",'" + EstadoCivil + "','" + Ocupacino + "','" + Colegio + "','" + Domicilio + "','" + Localidad + "','" + Telefono + "','" + TelefonoAux +"'," + IDObraSocial + "," +
                "'"+DerivadoPor+"','"+AcompañadoPor+"')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
        }

    }
}
