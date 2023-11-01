<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment_One.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            select an item
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged1" Width="264px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem Value="bugatti.jpg">Bugatti</asp:ListItem>
                <asp:ListItem Value="Porsche.jpg">Porsche</asp:ListItem>
                <asp:ListItem Value="rolls royce.jpg">Rolls Royce</asp:ListItem>
                <asp:ListItem Value="Defender.jpg">Defender</asp:ListItem>
                <asp:ListItem Value="innova.jpg">Innova</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Image ID="Image1" runat="server" Height="482px" Width="1082px" />
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="width: 84px; height: 35px" Text="Cost" />
       
            
        </p>
        <p>
            &nbsp;</p>
        <asp:Label ID="Label1" runat="server" Text="$0"></asp:Label>
    </form>
</body>
</html>
