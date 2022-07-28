using Modelo;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace PuebaTecnica.Utilidades
{
    public class Comun
    {
        private const string LLENAR_FILTRO_CUADRO = "Select Distinct  CONCAT(CODIGO_CUADRO, '-', NUMERO_SOLUCION) CODIGO_CUADRO from CUADROS_SOLUCIONES_DET";
        private const string LLENAR_FILTRO_TRAYECTO_CASCADA = "Select Distinct CODIGO_TRAYECTO from CUADROS_SOLUCIONES_DET where CONCAT(CODIGO_CUADRO,'-',NUMERO_SOLUCION)=@P_CODIGO_CUADRO";

        public void LlenarFiltroCuadro(DropDownList dropDownList)
        {
            AccesoDatos.CargarDropDownListDesdeConsulta(dropDownList, LLENAR_FILTRO_CUADRO, "CODIGO_CUADRO", "CODIGO_CUADRO");
        }

        public void LlenarFiltroTrayecto(DropDownList dropDownList, string concatenar)
        {
            AccesoDatos.CargarDropDownListDesdeConsulta(dropDownList, LLENAR_FILTRO_TRAYECTO_CASCADA, "CODIGO_TRAYECTO", "CODIGO_TRAYECTO", concatenar);
        }

        public DataTable ObtenerReporte(string idCuadro, string idTrayecto="")
        {
            DataTable tabla = new DataTable();
            tabla = AccesoDatos.ObtenerInformacionReporte(idCuadro, idTrayecto);

            return tabla;
        }
    }
}