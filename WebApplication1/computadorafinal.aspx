<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="computadorafinal.aspx.cs" Inherits="WebApplication1.computadorafinal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Text="Guardar Nueva Computadora Final"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numero de Serie Cpu"></asp:Label>
&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <asp:Label ID="Label3" runat="server" Text="Selecciona Cpu"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Numero se serie Teclado"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
        Selecciona teclado:<asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        Numero de Serie teclado:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Numero de serie monitor:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Selecciona monitor:<asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        numero de serie mause:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        Seleciona mause:<asp:DropDownList ID="DropDownList4" runat="server" style="margin-bottom: 4px">
        </asp:DropDownList>
        <br />
        <br />
        Estado:<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Guardar" />
&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ver datos" />
&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Editar" />
&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Eliminar" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="Seleccionar" />
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <SortedAscendingCellStyle BackColor="#FEFCEB" />
            <SortedAscendingHeaderStyle BackColor="#AF0101" />
            <SortedDescendingCellStyle BackColor="#F6F0C0" />
            <SortedDescendingHeaderStyle BackColor="#7E0000" />
        </asp:GridView>
        <br />
        <br />
    </form>
</body>
</html>
