<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="EsercizioW2E5.WebForm2" EnableEventValidation="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button2_Click" />
        <asp:Button ID="Button2" runat="server" Text="Svuota cestino" OnClick="Button3_Click" />
        <div>
            <h1>Carrello</h1>
            <ul id="carrelloList" runat="server">
    <asp:Repeater runat="server" ID="repeaterCarrello">
        <ItemTemplate>
            <li>
                <h3><%# Eval("Nome") %></h3>
                <p><%# Eval("Descrizione") %></p>
                <p>Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                <hr />
                <asp:Button runat="server" CssClass="btn btn-danger" Text="Rimuovi" OnClick="RimuoviCarrello_Click" CommandArgument='<%# Eval("Id") %>' />
            </li>
        </ItemTemplate>
    </asp:Repeater>
</ul>
            
        </div>
    </form>
</body>
</html>
