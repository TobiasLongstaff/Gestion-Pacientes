using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegosio
{
    public class CN_Pacientes
    {
        private CD_Pacientes objetoCD = new CD_Pacientes();
        public DataTable MostrarPa()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public DataTable MostarObra()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaObraSocial();
            return tabla;
        }

        public DataTable MostrarRegistroDia()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaRegistroDiario();
            return tabla;            
        }

        public DataTable BarraDeBusquedaPaciente(string NombreYApellido)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarNombreYApellidoPaciente(NombreYApellido);
            return tabla;
        }

        public DataTable BarraDeBusquedaRegistro(string NombreYApellido)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarNombreYApellidoRegistro(NombreYApellido);
            return tabla;
        }

        public DataTable BarraDeBusquedaAdmision(string NombreYApellido)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarNombreYApellidoAdmision(NombreYApellido);
            return tabla;
        }

        public DataTable SelcionarObra(string IDObraSocial)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.SelecionarObraSocial(Convert.ToInt32(IDObraSocial));
            return tabla;
        }

        public DataTable MostarObrasocial1()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarObraSocial();
            return tabla;
        }

        public DataTable BuscarEvaluacion(string NombreDelArchivo)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.BuscarEvaluaciones(NombreDelArchivo);
            return tabla;
        }

        public void insertarPa(string Nombre, string Apellido, string IDObraSocial, string FechaDeNacimiento, string NumeroDeAfiliado, string Telefono, string DNI)
        {
            objetoCD.insertar(Nombre, Apellido, Convert.ToInt32(IDObraSocial), FechaDeNacimiento, NumeroDeAfiliado, Telefono, Convert.ToInt32(DNI));
        }

        public void insertarPagoObra(string FechaDePago, string IDObraSocial, string TotalPagado)
        {
            objetoCD.InsertarPagoObraSocial(FechaDePago, Convert.ToInt32(IDObraSocial), TotalPagado);
        }

        public void insertarRegistro(string Fecha, string Hora, string NombreYApellido, string IDPaciente, string AusenteOPresente)
        {
            objetoCD.insertarRegistroDiario(Fecha, Hora, NombreYApellido, Convert.ToInt32(IDPaciente), AusenteOPresente);
        }

        public void insertarObra(string ObrasSociales )
        {
            objetoCD.InsertarObraSocial(ObrasSociales);
        }

        public void InsertarEvalua(string NombreDelArchivo, string DireccionDelArchivo, string TipoDeArchivo)
        {
            objetoCD.InsetarEvaluacionOInforme(NombreDelArchivo, DireccionDelArchivo, TipoDeArchivo);
        }

        public void EditarPa (string Nombre, string Apellido, string IDObraSocial, string FechaDeNacimiento, string NumeroDeAfiliado, string Telefono, string DNI, string ID)
        {
            objetoCD.Editar(Nombre, Apellido, Convert.ToInt32(IDObraSocial), FechaDeNacimiento, NumeroDeAfiliado, Telefono, Convert.ToInt32(DNI) ,Convert.ToInt32(ID));
        }

        public void EliminarPa(string Id)
        {
            objetoCD.Eliminar(Convert.ToInt32(Id));           
        }

        public void EliminarRegistroDia(string Id)
        {
            objetoCD.EliminarRegistroDiario(Convert.ToInt32(Id));
        }

        public void EliminarObra(string Id)
        {
            objetoCD.EliminarObraSocial(Convert.ToInt32(Id));
        }

        public void crearcuenta (string Usuario, string Nombre, string Apellido, string Mail, string FDN, string Contraseña)
        {
            objetoCD.AgregarCuenta(Usuario, Nombre, Apellido, Mail, FDN, Contraseña);
        }

        public void EditarPerfil (string Usuario, string Contraseña, string Id)
        {
            objetoCD.EditarPerfil(Usuario, Contraseña, Convert.ToInt32(Id));
        }

        public void InsertarAdmi(string HCN, string NombreYApellido, string Edad, string FechaDeNacimiento, string Nacionalidad, string TipoYNDocumento,
            string EstadoCivil, string Ocupacino, string Colegio, string Domicilio, string Localidad, string Telefono, string TelefonoAux, string IDObraSocial,
            string DerivadoPor, string AcompañadoPor)
        {
            objetoCD.InsertarAdmision(HCN ,NombreYApellido, Convert.ToInt32(Edad), FechaDeNacimiento, Nacionalidad, Convert.ToInt32(TipoYNDocumento),
                EstadoCivil, Ocupacino, Colegio, Domicilio, Localidad, Telefono, TelefonoAux, 
                Convert.ToInt32(IDObraSocial), DerivadoPor, AcompañadoPor);
        }

        public void EditarAdmi(string HCN, string NombreYApellido, string Edad, string FechaDeNacimiento, string Nacionalidad, string TipoYNDocumento,
        string EstadoCivil, string Ocupacino, string Colegio, string Domicilio, string Localidad, string Telefono, string TelefonoAux, string IDObraSocial,
        string DerivadoPor, string AcompañadoPor, string id)
        {
            objetoCD.EditarAdmision(HCN, NombreYApellido, Convert.ToInt32(Edad), FechaDeNacimiento, Nacionalidad, Convert.ToInt32(TipoYNDocumento),
                EstadoCivil, Ocupacino, Colegio, Domicilio, Localidad, Telefono, TelefonoAux,
                Convert.ToInt32(IDObraSocial), DerivadoPor, AcompañadoPor, Convert.ToInt32(id));
        }
    }
}
