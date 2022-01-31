<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DropListBox.aspx.vb" Inherits="Controller.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:DropDownList ID="dropBox" runat="server" AutoPostBack="true"></asp:DropDownList>

            <br />
            <br />
            <br />
            <br />

            <asp:ListBox ID="listBox" runat="server"></asp:ListBox>

            <br />
            <br />
            <br />
            <br />

            <asp:Button ID="btn" runat="server" Text="Button" />

        </div>
    </form>
</body>
</html>
