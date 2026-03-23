<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GgtRechner.aspx.cs" Inherits="Größter_gemeinsamer_Teiler.GgtRechner" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Zahl 1"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 36px; top: 193px; position: absolute; height: 27px; width: 76px" Text="Zahl2"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 33px; top: 343px; position: absolute; height: 31px; width: 347px" Text="Größter gemeinsame Teiler:"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 15px; top: 527px; position: absolute; height: 48px; width: 78px" Text="Timer"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 22px; top: 52px; position: absolute; height: 94px; width: 614px"></asp:TextBox>
        </div>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 28px; top: 233px; position: absolute; height: 90px; width: 569px; margin-top: 4px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 873px; top: 186px; position: absolute; height: 75px; width: 306px" Text="normal(langsam)" />
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 4px; top: 392px; position: absolute; height: 95px; width: 796px" Enabled="False"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 146px; top: 497px; position: absolute; height: 85px; width: 915px; margin-top: 10px" Enabled="False"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 865px; top: 325px; position: absolute; height: 82px; width: 308px" Text="Euklidisch(schnell)" />
        <p>
            &nbsp;</p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 864px; top: 97px; position: absolute; height: 32px; width: 297px" Text="Euklidisch (rekursiv)" />
    </form>
</body>
</html>

