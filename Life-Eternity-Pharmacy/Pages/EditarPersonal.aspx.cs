using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class EditarPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idPersonal = Convert.ToInt32(Request.QueryString["id"]);
                TxtidPersonal.Text = idPersonal.ToString();

                try
                {
                    using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                    {
                        var datosPersonal = db.SPPersonalConsultarPorID(idPersonal).FirstOrDefault();

                        if (datosPersonal != null)
                        {
                            TxtNombre.Text = datosPersonal.nombre;
                            TxtApellido.Text = datosPersonal.apellido;
                            TxtDireccion.Text = datosPersonal.direccion;
                            TxtTelefono.Text = datosPersonal.telefono;
                            TxtCorreo.Text = datosPersonal.correo;
                            TxtRol.Text = datosPersonal.rol;
                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/ErrorPersonal.aspx");
                }

            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersonal = Convert.ToInt32(TxtidPersonal.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                string direccion = TxtDireccion.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string correo = TxtCorreo.Text.Trim();
                string rol = TxtRol.Text.Trim();


                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPPersonalModificar(idPersonal, nombre, apellido, direccion, telefono, correo, rol);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/ErrorPersonal.aspx");
            }
            Response.Redirect("ResultadoEditarPersonal.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idPersonal = Convert.ToInt32(TxtidPersonal.Text.Trim());
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPPersonalEliminar(idPersonal);
                }
            }
            catch (Exception)
            {

                Response.Redirect("ErrorPersonal.aspx");
            }
            Response.Redirect("ResultadoEliminarPersonal.aspx");
        }
    }
}