using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioW2E5
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(GestoreProdotti.listaProdotti.Count == 0)
            {
                GestoreProdotti.listaProdotti.Add(new Prodotto(1, "Prodotto 1", "Descrizione del prodotto 1", 10.99m, "Categoria 1", "immagine1.jpg"));
                GestoreProdotti.listaProdotti.Add(new Prodotto(2, "Prodotto 2", "Descrizione del prodotto 2", 19.99m, "Categoria 2", "immagine2.jpg"));
                GestoreProdotti.listaProdotti.Add(new Prodotto(3, "Prodotto 3", "Descrizione del prodotto 3", 15.49m, "Categoria 1", "immagine3.jpg"));
            }



            foreach (var prodotto in GestoreProdotti.listaProdotti)
            {
                string htmlOutput = $@"
        <div class='card' style='width: 18rem;'>
            <img src='{prodotto.ImmagineUrl}' class='card-img-top' alt='Immagine prodotto'>
            <div class='card-body'>
                <h5 class='card-title'>{prodotto.Nome}</h5>
                <p class='card-text'>{prodotto.Descrizione}</p>
                <p class='card-text'>Prezzo: {prodotto.Prezzo} €</p>
                <p class='card-text'>Categoria: {prodotto.Categoria}</p>
                <!-- Pulsante per il dettaglio del prodotto -->
                <a href='DettagliProdotto.aspx?id={prodotto.Id}' class='btn btn-primary'>Dettagli</a>
            </div>
        </div>";

                Panel1.Controls.Add(new LiteralControl(htmlOutput));
            }
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }
    }

   



    public static class GestoreProdotti
    {
        public static List<Prodotto> listaProdotti = new List<Prodotto>();
    }


    public static class Carrello
    {
        public static List<Prodotto> carrello = new List<Prodotto>();
    }







    public class Prodotto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descrizione { get; set; }

        public decimal Prezzo { get; set; }
        public string Categoria { get; set; }
        public string ImmagineUrl { get; set; }

        public Prodotto(int id, string nome, string descrizione, decimal prezzo, string categoria, string immagineUrl)
        {
            Id = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Categoria = categoria;
            ImmagineUrl = immagineUrl;
        }
    }
}