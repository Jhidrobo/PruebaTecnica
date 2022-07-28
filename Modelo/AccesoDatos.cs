using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Data;

namespace Modelo
{
    public class AccesoDatos
    {
        private const string NOMBRE_CADENA_CONEXION = "Goalbus";
               
        public static SqlConnection Conectar()
        {
            string cadenaConexion = null;

            cadenaConexion = ConfigurationManager.ConnectionStrings[NOMBRE_CADENA_CONEXION].ConnectionString;
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public static void CargarDropDownListDesdeConsulta(DropDownList dropDownList, string filtro, string texto, string valor, string concatenar = null)
        {

            using (SqlConnection conexion = AccesoDatos.Conectar())
            using (SqlCommand comando = conexion.CreateCommand())
            {
                comando.CommandType = CommandType.Text;
                comando.CommandText = filtro;

                if (concatenar != null)
                {
                    comando.Parameters.AddWithValue("@P_CODIGO_CUADRO", concatenar);
                }

                SqlDataAdapter da = new SqlDataAdapter(comando);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dropDownList.DataSource = ds;
                dropDownList.DataTextField =  texto;
                dropDownList.DataValueField = valor;
                dropDownList.DataBind();
                dropDownList.Items.Insert(0, new ListItem("<Seleccionar>", "0"));

                conexion.Close();                
            }
        }

        public static DataTable ObtenerInformacionReporte(string idCuadro, string idTrayecto="")
        {
            SqlConnection conexion = AccesoDatos.Conectar();
            SqlDataAdapter adapter = new SqlDataAdapter(idTrayecto=="" ? "sp_Reporte1" : "sp_Reporte2",conexion);
            DataTable tabla = new DataTable();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@idCuadro", SqlDbType.VarChar).Value = idCuadro;
            if(idTrayecto != "")
            {
                adapter.SelectCommand.Parameters.Add("@idTrayecto", SqlDbType.VarChar).Value = idTrayecto;
            }
            adapter.Fill(tabla);

            conexion.Close();

            return tabla;
        }
    }
}
