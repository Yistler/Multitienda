using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Multitienda.Negocio;

namespace WebMultitienda
{
    public partial class Producto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Index.aspx");
        }
        private void LimpiarControles()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtIdCategoria.Text = string.Empty;
        }
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //Se crea una instancia de Producto luego devuelve true si el producto existe si no false
            try
            {
                Multitienda.Negocio.Producto mult = new Multitienda.Negocio.Producto();
                mult.idProducto = int.Parse(txtId.Text);

                if (!mult.Read())
                {
                    mult.Nombre = txtNombre.Text;
                    mult.Descripcion = txtDescripcion.Text;
                    mult.idCategoria = int.Parse(txtIdCategoria.Text);

                    mult.Create();

                    lblMensaje.Text = "Producto registrado";

                }
                else
                {
                    lblMensaje.Text = "Id Producto ya existe";
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Producto ya existe";
                LimpiarControles();
            }
        }
    }
}