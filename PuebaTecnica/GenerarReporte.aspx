<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerarReporte.aspx.cs" Inherits="PuebaTecnica.GenerarReporte" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        @import "CSS/Estilos.css";
    </style>
</head>
<body style="height: 288px">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


        <h1>Prueba Técnica 2022</h1>

        <p>
            <div>Seleccione el reporte que desea revisar</div>
            <asp:RadioButtonList CssClass="lbl" ID="rblReportes" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblReportes_SelectedIndexChanged">
                <asp:ListItem>Reporte 1</asp:ListItem>
                <asp:ListItem>Reporte 2</asp:ListItem>
            </asp:RadioButtonList>
        </p>

        <table id="tblReporte1" runat="server" visible="false">
            <tbody>
                <tr>
                    <td>
                        <asp:Label CssClass="lbl" ID="lblCuadro" runat="server" Text="Código Cuadro: "></asp:Label>
                        <asp:DropDownList CssClass="bordeLst" ID="lstCuadro" runat="server" OnSelectedIndexChanged="lstCuadro_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                    </td>
                </tr>
            </tbody>
        </table>
        <table id="tblReporte2" runat="server" visible="false">
            <tbody>
                <tr>
                    <td>
                        <asp:Label CssClass="lbl" ID="lblTrayecto" runat="server" Text="Código Trayecto: "></asp:Label>
                        <asp:DropDownList CssClass="bordeLst" ID="lstTrayecto" runat="server"></asp:DropDownList>
                    </td>
                </tr>
            </tbody>
        </table>

        <p>
            <asp:Button CssClass="btn btn-primary" ID="Generar" runat="server" Text="Generar reporte" OnClick="Generar_Click" />
        </p>



        <div>
            <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" Enabled="False" Height="401px" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="884px" ShowDocumentMapButton="False" ShowExportControls="False" ShowPrintButton="False">
                <LocalReport ReportPath="Reportes\Report1.rdlc">
                </LocalReport>
            </rsweb:ReportViewer>
        </div>


    </form>
</body>
</html>
