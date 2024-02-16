using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioW2E5
{
    public partial class DettagliProdotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string productId = Request.QueryString["id"];
                int id;

                if (int.TryParse(productId, out id))
                {
                    Prodotto prodottoSelezionato = GestoreProdotti.listaProdotti.FirstOrDefault(p => p.Id == id);
                    if (prodottoSelezionato != null)
                    {
                        List<Prodotto> prodottoSingolo = new List<Prodotto> { prodottoSelezionato };
                        RepeaterProdotti.DataSource = prodottoSingolo;
                        RepeaterProdotti.DataBind();
                    }
                }
            }
        }


        protected void AggiungiCarrello_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int productId = Convert.ToInt32(btn.CommandArgument);
            AggiungiCarrello(productId);
        }

        private void AggiungiCarrello(int productId)
        {
           
            Prodotto prodotto = GestoreProdotti.listaProdotti.FirstOrDefault(p => p.Id == productId);

            Carrello.carrello.Add(prodotto);
        }




        public void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        public  void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }
    }
}