<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display.aspx.cs" Inherits="WebApplication1.Display" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <label >Employee Details</label>
    <asp:GridView  runat="server" ID="Empgv" AutoGenerateColumns ="true"></asp:GridView>
    </div>
    </form>
</body>
</html>
