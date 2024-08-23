using Life_Eternity_Pharmacy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Life_Eternity_Pharmacy.Pages
{
    public partial class CrearVenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
            //    {

            //        var Lista = db.SPDetalleVentaListar().ToList();


            //        GvListaDetalleVenta.DataSource = Lista;
            //        GvListaDetalleVenta.DataBind();


            //        var Listap = db.SPVentasListar().ToList();

            //        GvListaVenta.DataSource = Listap;
            //        GvListaVenta.DataBind();
            //    }

            //}
            //catch (Exception)
            //{
            //    Response.Redirect("~/Pages/ErrorVenta.aspx");
            //}

            if (!Page.IsPostBack)
            {
                LlenarListaUsuario();
                LlenarListaCliente();
                LlenarListaPersonal();
                LlenarListaVenta();
                LlenarListaProducto();

            }


        }

        private void LlenarListaUsuario()
        {
            try
            {
                var ListaUsuario = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPUsuarioListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_usuario.ToString(),
                                     Text = lr.nombre + " =>" + lr.descripcion
                                 }
                                 ).ToList();

                    ListaUsuario.AddRange(query);

                    DdlUsuario.DataTextField = "Text";
                    DdlUsuario.DataValueField = "Value";

                    DdlUsuario.DataSource = ListaUsuario;
                    DdlUsuario.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorVenta.aspx");
            }
        }

        private void LlenarListaCliente()
        {
            try
            {
                var ListaCliente = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPClienteListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_cliente.ToString(),
                                     Text = lr.apellido + " " + lr.nombre
                                 }
                                 ).ToList();

                    ListaCliente.AddRange(query);

                    DdlCliente.DataTextField = "Text";
                    DdlCliente.DataValueField = "Value";

                    DdlCliente.DataSource = ListaCliente;
                    DdlCliente.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorVenta.aspx");
            }
        }

        private void LlenarListaPersonal()
        {
            try
            {
                var ListaPersonal = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPPersonalListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_personal.ToString(),
                                     Text = lr.apellido + " " + lr.nombre + " =>" + lr.rol
                                 }
                                 ).ToList();

                    ListaPersonal.AddRange(query);

                    DdlPersonal.DataTextField = "Text";
                    DdlPersonal.DataValueField = "Value";

                    DdlPersonal.DataSource = ListaPersonal;
                    DdlPersonal.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorVenta.aspx");
            }
        }

        private void LlenarListaVenta()
        {
            try
            {
                var ListaVenta = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPVentasListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_venta.ToString(),
                                     Text = lr.nombreUsuario + " " + lr.nombreCliente + " =>" + lr.nombrePersonal
                                 }
                                 ).ToList();

                    ListaVenta.AddRange(query);

                    DdlVenta.DataTextField = "Text";
                    DdlVenta.DataValueField = "Value";

                    DdlVenta.DataSource = ListaVenta;
                    DdlVenta.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorVenta.aspx");
            }
        }

        private void LlenarListaProducto()
        {
            try
            {
                var ListaProducto = new List<ListItem>();

                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {

                    var query = (from lr in db.SPProductoListar()
                                 select new ListItem
                                 {
                                     Value = lr.id_producto.ToString(),
                                     Text = lr.nombre + " " +
                                     lr.descripcion + " " + lr.descripCatego + " Precio> " +
                                     lr.precio + "< =>" + lr.stock + " " + lr.nombreProvee
                                 }
                                 ).ToList();

                    ListaProducto.AddRange(query);

                    DdlProducto.DataTextField = "Text";
                    DdlProducto.DataValueField = "Value";

                    DdlProducto.DataSource = ListaProducto;
                    DdlProducto.DataBind();
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorVenta.aspx");
            }
        }

        protected void BtnAgregar_Click(object sender, EventArgs e)
        {
            int idUsuario = Convert.ToInt32(DdlUsuario.SelectedItem.Value);
            int idCliente = Convert.ToInt32(DdlCliente.SelectedItem.Value);
            int idPersonal = Convert.ToInt32(DdlPersonal.SelectedItem.Value);

            DateTime fecha = Convert.ToDateTime(TxtFecha.Text.Trim());
            string tipoComprobante = TxtTipoComprobante.Text.Trim();

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPVentaAgregar(idUsuario, idCliente, idPersonal, fecha, tipoComprobante);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorVenta.aspx");
            }
            // Muestra un mensaje de éxito
            LbAgregarResultado.Text = "La venta se ha agregado exitosamente.";
        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            int idVenta = Convert.ToInt32(DdlVenta.SelectedItem.Value);
            int idProducto = Convert.ToInt32(DdlProducto.SelectedItem.Value);

            int cantidad = Convert.ToInt32(TxtCantidad.Text.Trim());
            float precio = (float)Convert.ToDecimal(TxtPrecio.Text.Trim());
            float impuesto = (float)Convert.ToDecimal(TxtImpuesto.Text.Trim());

            try
            {
                using (Pharmacy_Life_EternityEntities db = new Pharmacy_Life_EternityEntities())
                {
                    db.SPDetalleVentaAgregar(idVenta, idProducto, cantidad, precio, impuesto);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/ErrorVenta.aspx");
            }
            // Muestra un mensaje de éxito
            LbInsertarResultado.Text = "El detalle venta se ha agregado exitosamente.";
        }
    }
}