using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class CrearProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaProveedor();
                LlenarListaCategoria();
            }
        }

        private void LlenarListaProveedor()
        {
            try
            {
                var ListaProveedor = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPProveedorListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_proveedor.ToString(),
                                     Text = lr.nombre
                                 }
                                 ).ToList();

                    ListaProveedor.AddRange(query);

                    DdlProveedor.DataTextField = "Text";
                    DdlProveedor.DataValueField = "Value";

                    DdlProveedor.DataSource = ListaProveedor;
                    DdlProveedor.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorProducto.aspx");
            }
        }

        private void LlenarListaCategoria()
        {
            try
            {
                var ListaCategoria = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPCategoriaListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_categoria.ToString(),
                                     Text = lr.descripcion
                                 }
                                 ).ToList();

                    ListaCategoria.AddRange(query);

                    DdlCategoria.DataTextField = "Text";
                    DdlCategoria.DataValueField = "Value";

                    DdlCategoria.DataSource = ListaCategoria;
                    DdlCategoria.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorProducto.aspx");
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text.Trim();
            string descripcion = TxtDescripcion.Text.Trim();
            float precio = (float)Convert.ToDecimal(TxtPrecio.Text.Trim());
            int stock = Convert.ToInt32(TxtStock.Text.Trim());

            int idProveedor = Convert.ToInt32(DdlProveedor.SelectedItem.Value);
            int idCategoria = Convert.ToInt32(DdlCategoria.SelectedItem.Value);

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProductoAgregar(nombre,descripcion, precio, stock, idProveedor, idCategoria);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorProducto.aspx");
            }

            Response.Redirect("~/Pages/ExitoCrearProducto.aspx");
        }
    }
}