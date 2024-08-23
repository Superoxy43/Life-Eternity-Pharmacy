using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class EditarCategoria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idCategoria = Convert.ToInt32(Request.QueryString["id"]);
                TxtidCategoria.Text = idCategoria.ToString();

                try
                {
                    using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                    {
                        var datosCategoria = db.SPCategoriaConsultarPorID(idCategoria).FirstOrDefault();

                        if (datosCategoria != null)
                        {
                            TxtNombre.Text = datosCategoria.nombre;
                            TxtDescripcion.Text = datosCategoria.descripcion;
                            TxtCondicion.Text = datosCategoria.condicion.ToString();

                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/ErrorCategoria.aspx");
                }

            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(TxtidCategoria.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string descripcion = TxtDescripcion.Text.Trim();
                char condicion = Convert.ToChar(TxtCondicion.Text.Trim());


                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPCategoriaModificar(idCategoria, nombre, descripcion, condicion);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/ErrorProveedor.aspx");
            }
            Response.Redirect("ResultadoEditarCategoria.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(TxtidCategoria.Text.Trim());
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPCategoriaEliminar(idCategoria);
                }
            }
            catch (Exception)
            {

                Response.Redirect("ErrorCategoria.aspx");
            }
            Response.Redirect("ResultadoEliminarCategoria.aspx");
        }
    }
}