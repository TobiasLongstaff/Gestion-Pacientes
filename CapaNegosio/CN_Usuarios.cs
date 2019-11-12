using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegosio
{
    public class CN_Usuarios
    {
        CD_Usuarios cd_usuario = new CD_Usuarios();
        public bool LoginUser(string Usuario, string Contraseña)
        {
            return cd_usuario.Login(Usuario, Contraseña);
        }

        public bool BuscarFic(string NombreYApellido)
        {
            return cd_usuario.BuscarFicha(NombreYApellido);
        }
    }
}
