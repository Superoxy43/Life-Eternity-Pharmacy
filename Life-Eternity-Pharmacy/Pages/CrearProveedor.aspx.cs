using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class CrearProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string direccion = TxtDireccion.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();
            string correo = TxtCorreo.Text.Trim();

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProveedorAgregar(nombre, direccion, telefono, correo);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorProveedor.aspx");
            }

            Response.Redirect("~/Pages/ExitoCrearProveedor.aspx");
        }
    }
}