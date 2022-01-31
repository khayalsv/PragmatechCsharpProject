<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FileUpload.aspx.vb" Inherits="Controls.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <asp:FileUpload ID="FileUpload1" runat="server" />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
