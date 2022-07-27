<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="laboratorio.aspx.cs" Inherits="WebApplication1.laboratorio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Guardar Nuevo Laboratorio"></asp:Label>
            <br />
            <br />
            Nombre Laboratorio:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
&nbsp;<br />
            <asp:Button ID="Button1" runat="server" Text="Guardar" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text=" Ver datos" />
&nbsp;
            <asp:Button ID="Button3" runat="server" Text="Editar" />
&nbsp;
            <asp:Button ID="Button4" runat="server" Text="Eliminar" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <Columns>
                    <asp:ButtonField ButtonType="Button" Text="Seleccionar" />
                </Columns>
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
            </asp:GridView>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
