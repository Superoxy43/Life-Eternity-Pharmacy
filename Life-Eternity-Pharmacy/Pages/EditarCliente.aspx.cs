using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class EditarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int idCliente = Convert.ToInt32(Request.QueryString["id"]);
                TxtidCliente.Text = idCliente.ToString();

                try
                {
                    using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                    {
                        var datosCliente = db.SPClienteConsultarPorID(idCliente).FirstOrDefault();

                        if (datosCliente != null)
                        {
                            TxtNombre.Text = datosCliente.nombre;
                            TxtApellido.Text = datosCliente.apellido;
                            TxtDireccion.Text = datosCliente.direccion;
                            TxtTelefono.Text = datosCliente.telefono;
                            TxtCorreo.Text = datosCliente.correo;

                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("~/Pages/ErrorCliente.aspx");
                }

            }
        }

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(TxtidCliente.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string apellido = TxtApellido.Text.Trim();
                string direccion = TxtDireccion.Text.Trim();
                string telefono = TxtTelefono.Text.Trim();
                string correo = TxtCorreo.Text.Trim();


                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPClienteModificar(idCliente, nombre, apellido, direccion, telefono, correo);
                }
            }
            catch (Exception)
            {

                Response.Redirect("~/Pages/ErrorCliente.aspx");
            }
            Response.Redirect("ResultadoEditarCliente.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(TxtidCliente.Text.Trim());
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPClienteEliminar(idCliente);
                }
            }
            catch (Exception)
            {

                Response.Redirect("ErrorCliente.aspx");
            }
            Response.Redirect("ResultadoEliminarCliente.aspx");
        }
    }
}