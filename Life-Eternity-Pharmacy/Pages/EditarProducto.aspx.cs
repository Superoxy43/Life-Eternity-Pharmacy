using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class EditarProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                LlenarListaProveedor();
                LlenarListaCategoria();
                CargarInformacionDelProducto();
            }
        }

        private void CargarInformacionDelProducto()
        {
            int idProducto = Convert.ToInt32(Request.QueryString["id"]);
            TxtidProducto.Text = idProducto.ToString();

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    var datosProducto = db.SPProductoConsultarPorID(idProducto).FirstOrDefault();

                    if (datosProducto != null)
                    {
                        TxtNombre.Text = datosProducto.nombre;
                        TxtDescripcion.Text = datosProducto.descripcion;
                        TxtPrecio.Text = datosProducto.precio.ToString();
                        TxtStock.Text = datosProducto.stock.ToString();


                        string idProveedor = datosProducto.id_proveedor.ToString();
                        DdlProveedor.Items.FindByValue(idProveedor).Selected = true;

                        string idCategoria = datosProducto.id_categoria.ToString();
                        DdlCategoria.Items.FindByValue(idCategoria).Selected = true;


                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorProducto.aspx");
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

        protected void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(TxtidProducto.Text.Trim());
                string nombre = TxtNombre.Text.Trim();
                string descripcion = TxtDescripcion.Text.Trim();
                float precio = (float)Convert.ToDecimal(TxtPrecio.Text.Trim());
                int stock = Convert.ToInt32(TxtStock.Text.Trim());

                int idProveedor = Convert.ToInt32(DdlProveedor.SelectedItem.Value);
                int idCategoria = Convert.ToInt32(DdlCategoria.SelectedItem.Value);

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProductoModificar(idProducto, nombre, descripcion, precio, stock, idProveedor, idCategoria);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorProducto.aspx");
            }
            Response.Redirect("ResultadoEditarProducto.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = Convert.ToInt32(TxtidProducto.Text.Trim());
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPProductoEliminar(idProducto);
                }
            }
            catch (Exception)
            {

                Response.Redirect("ErrorProducto.aspx");
            }
            Response.Redirect("ResultadoEliminarProducto.aspx");
        }
    }
}