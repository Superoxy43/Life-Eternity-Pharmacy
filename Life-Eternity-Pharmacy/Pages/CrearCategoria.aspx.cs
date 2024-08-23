using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class CrearCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string descripcion = TxtDescripcion.Text.Trim();
            char condicion = Convert.ToChar(TxtCondicion.Text.Trim());


            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPCategoriaAgregar(nombre, descripcion, condicion);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorCategoria.aspx");
            }

            Response.Redirect("~/Pages/ExitoCrearCategoria.aspx");
        }
    }
}