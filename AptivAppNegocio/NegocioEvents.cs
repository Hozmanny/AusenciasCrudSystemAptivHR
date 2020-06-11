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
    public class NegocioEvents
    {
        public static DataTable Listar()
        {
            DEvents Datos = new DEvents();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DEvents Datos = new DEvents();
            return Datos.Buscar(Valor);
        }
        public static string Insertar(int id, string nombre, string linea, string turno, string evento, string inicio, string fin, string comentario, string aprovo)
        {
            DEvents Datos = new DEvents();
            Events Obj = new Events();
            Obj.Emp_Id = id;
            Obj.Emp_Name = nombre;
            Obj.Emp_Event = evento;
            Obj.Emp_Aproval = aprovo;
            Obj.Emp_Comment = comentario;
            Obj.Emp_Line = linea;
            Obj.Emp_Workshift = turno;
            Obj.Emp_StartDate = inicio;
            Obj.Emp_EndDate = fin;
            return Datos.Insertar(Obj);
        }
    }
}
