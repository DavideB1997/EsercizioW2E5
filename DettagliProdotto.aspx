<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DettagliProdotto.aspx.cs" Inherits="EsercizioW2E5.DettagliProdotto" EnableEventValidation="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="~/Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
      <asp:Button ID="Button1" runat="server" Text="Home" OnClick="Button1_Click" />
      <asp:Button ID="Button2" runat="server" Text="Carrello" OnClick="Button2_Click" />
    
    

                       <asp:Repeater runat="server" ID="RepeaterProdotti">
    <ItemTemplate>
        <div class='card' style='width: 18rem;'>
            <img src='<%# Eval("ImmagineUrl") %>' class='card-img-top' alt='Immagine prodotto'>
            <div class='card-body'>
                <h5 class='card-title'><%# Eval("Nome") %></h5>
                <p class='card-text'><%# Eval("Descrizione") %></p>
                <p class='card-text'>Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                <p class='card-text'>Categoria: <%# Eval("Categoria") %></p>
                <!-- Pulsante per il dettaglio del prodotto -->
                <asp:Button runat="server" CssClass="btn btn-primary" Text="Dettagli" CommandName="Dettagli" CommandArgument='<%# Eval("Id") %>' />
                <asp:Button runat="server" CssClass="btn btn-success" Text="Aggiungi al Carrello" OnClick="AggiungiCarrello_Click" CommandArgument='<%# Eval("Id") %>' />
            </div>
        </div>
    </ItemTemplate>
</asp:Repeater>

        </form>
</body>
</html>
