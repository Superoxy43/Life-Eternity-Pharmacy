using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class ListaPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    var Lista = db.SPPersonalListar().ToList();

                    GvListaPersonal.DataSource = Lista;
                    GvListaPersonal.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorPersonal.aspx");
            }
        }
    }
}