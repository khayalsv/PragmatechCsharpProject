<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="StandartController._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:TextBox ID="txtMessage" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" Text="button" runat="server" style="height: 26px" />
            <br />
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
            
        </div>
    </form>
</body>
</html>
