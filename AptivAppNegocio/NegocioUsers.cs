using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AptivAppDatos;
using AptivAppEntidades;

namespace AptivAppNegocio
{
    public class NegocioUsers
    {
        public static DataTable Login(string Email, string Clave)
        {

            DUsers Datos = new DUsers();
            return Datos.Login(Email, Clave);
        }

        public static string Insertar(string Email, string Nombre, string Password, bool Superuser)
        {
            DUsers Datos = new DUsers();

            string Existe = Datos.Existe(Email);
            if (Existe.Equals("1"))
            {
                return "El usuario con ese email ya existe.";
            }
            else
            {
                Users Obj = new Users();
                Obj.User_Names = Nombre;
                Obj.User_Email = Email;
                Obj.User_Password = Password;
                Obj.User_SuperUser = Superuser;
                return Datos.Insertar(Obj);
            }
        }
    }
}
