<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CalendarForm.aspx.vb" Inherits="StandartController.CalendarForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Calendar ID="Calendar1" runat="server" 
                ShowGridLines="true" 
                NextMonthText="&amp;raquo;" 
                OnSelectionChanged="Calendar1_SelectionChanged">

                    <WeekendDayStyle BackColor="#FF0000" />

            </asp:Calendar>
            
        </div>
    </form>
</body>
</html>
