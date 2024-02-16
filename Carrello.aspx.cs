using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioW2E5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (var prodotto in Carrello.carrello)
                {
                    BindCarrello();

                }
            }
            
        }

        protected void BindCarrello()
        {
            repeaterCarrello.DataSource = Carrello.carrello;
            repeaterCarrello.DataBind();
        }

        protected void RimuoviCarrello_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int productId = Convert.ToInt32(btn.CommandArgument);

            RimuoviCarrello(productId);
            BindCarrello();
        }

        public static void RimuoviCarrello(int productId)
        {
            Prodotto prodotto = Carrello.carrello.FirstOrDefault(p => p.Id == productId);

            if (prodotto != null)
            {
                Carrello.carrello.Remove(prodotto);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SvuotaCarrello();
            BindCarrello();
        }

        public static void SvuotaCarrello()
        {
            Carrello.carrello.Clear();
        }

        public void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}