<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EsercizioW2E5.WebForm1" EnableEventValidation="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <asp:Button ID="Button2" runat="server" Text="Carrello" OnClick="Button2_Click" />
    </form>



        <asp:Panel ID="Panel1" runat="server" CssClass="d-flex">
           
        </asp:Panel>
</body>
</html>
