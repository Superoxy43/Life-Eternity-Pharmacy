using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class EditarProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idProveedor = Convert.ToInt32(Request.QueryString["id"]);
                TxtidProveedor.Text = idProveedor.ToString();

                try
                {
                    using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                    {
                        var datosProveedor = db.SPProveedorConsultarPorID(idProveedor).FirstOrDefault();

                        if (datosProveedor != null)
                        {
                            TxtNombre.Text = datosProveedor.nombre;
                            TxtDireccion.Text = datosProveedor.direccion;
                            TxtTelefono.Text = datosProveedor.telefono;
                            TxtCorreo.Text = datosProveedor.correo;

                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/ErrorProveedor.aspx");
                }

            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = Convert.ToInt32(TxtidProveedor.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string direccion = TxtDireccion.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string correo = TxtCorreo.Text.Trim();


                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProveedorModificar(idProveedor, nombre, direccion, telefono, correo);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/ErrorProveedor.aspx");
            }
            Response.Redirect("ResultadoEditarProveedor.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProveedor = Convert.ToInt32(TxtidProveedor.Text.Trim());
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProveedorEliminar(idProveedor);
                }
            }
            catch (Exception)
            {

                Response.Redirect("ErrorProveedor.aspx");
            }
            Response.Redirect("ResultadoEliminarProveedor.aspx");
        }
    }
}