﻿using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class CrearPersonal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();  
            string direccion = TxtDireccion.Text.Trim();
            string telefono = TxtTelefono.Text.Trim();
            string correo = TxtCorreo.Text.Trim();
            string rol = TxtRol.Text.Trim();

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPPersonalAgregar(nombre, apellido, direccion, telefono, correo, rol);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorPersonal.aspx");
            }

            Response.Redirect("~/Pages/ExitoCrearPersonal.aspx");
        
    }
}
}