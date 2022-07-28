using Microsoft.Reporting.WebForms;
using System;
using System.Data;
using System.Web.UI.WebControls;


namespace PuebaTecnica
{
    public partial class GenerarReporte : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCodigoCuadro();
                lstTrayecto.Items.Insert(0, new ListItem("<Seleccionar>", "0"));
                ReportViewer1.Visible = false;
            }
        }

        private void CargarCodigoCuadro()
        {
            Utilidades.Comun comun = new Utilidades.Comun();
            comun.LlenarFiltroCuadro(lstCuadro);
        }

        protected void lstCuadro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblReportes.SelectedIndex != 0)
            {
                Utilidades.Comun comun = new Utilidades.Comun();
                comun.LlenarFiltroTrayecto(lstTrayecto, lstCuadro.SelectedValue);
            }
        }

        protected void Generar_Click(object sender, EventArgs e)
        {
            var tabla = new DataTable();
            string dtSet;

            Utilidades.Comun comun = new Utilidades.Comun();

            ReportViewer1.LocalReport.DataSources.Clear();
            if (rblReportes.SelectedIndex == 0)
            {
                tabla = comun.ObtenerReporte(lstCuadro.SelectedValue);
                ReportViewer1.LocalReport.ReportPath = "Reportes/Report1.rdlc";
                dtSet = "DataSetRpt1";
            }
            else
            {
                tabla = comun.ObtenerReporte(lstCuadro.SelectedValue, lstTrayecto.SelectedValue);
                ReportViewer1.LocalReport.ReportPath = "Reportes/Report2.rdlc";
                dtSet = "DataSetRpt2";
            }

            ReportDataSource reporte = new ReportDataSource(dtSet, tabla);
            ReportViewer1.LocalReport.DataSources.Add(reporte);
            ReportViewer1.LocalReport.Refresh();

            ReportViewer1.Visible = true;
        }

        protected void rblReportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportViewer1.Visible = false;
            lstCuadro.SelectedIndex = 0;
            lstTrayecto.SelectedIndex = 0;

            if (rblReportes.SelectedIndex == 0)
            {
                tblReporte1.Visible = true;
                tblReporte2.Visible = false;
            }
            else
            {
                tblReporte1.Visible = true;
                tblReporte2.Visible = true;
            }
        }
    }
}