using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AptivAppEntidades;
using System.Data.SqlClient;

namespace AptivAppDatos
{
    public class DEvents
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Eventos_Listar",SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Eventos_Buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open)
                {
                    SqlCon.Close();
                }
            }
        }
        public string Insertar(Events Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("Eventos_Insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@empid", SqlDbType.Int).Value = Obj.Emp_Id;
                Comando.Parameters.Add("@empname", SqlDbType.VarChar).Value = Obj.Emp_Name;
                Comando.Parameters.Add("@empevent", SqlDbType.VarChar).Value = Obj.Emp_Event;
                Comando.Parameters.Add("@empaproval", SqlDbType.VarChar).Value = Obj.Emp_Aproval;
                Comando.Parameters.Add("@empcomment", SqlDbType.VarChar).Value = Obj.Emp_Comment;
                Comando.Parameters.Add("@empline", SqlDbType.VarChar).Value = Obj.Emp_Line;
                Comando.Parameters.Add("@empworkshift", SqlDbType.VarChar).Value = Obj.Emp_Workshift;
                Comando.Parameters.Add("@empstartdate", SqlDbType.VarChar).Value = Obj.Emp_StartDate;
                Comando.Parameters.Add("@empenddate", SqlDbType.VarChar).Value = Obj.Emp_EndDate;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se puedo ingresar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
