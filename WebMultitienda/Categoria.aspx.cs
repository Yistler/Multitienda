using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMultitienda
{
    public partial class Categoria : System.Web.UI.Page
    {
        private Multitienda.Negocio.CategoriaCollection multitiendas = new Multitienda.Negocio.CategoriaCollection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMultitiendas();
            }
        }

        private void CargarMultitiendas()
        {
            gvMultitiendas.DataSource = multitiendas.ReadAll();
            gvMultitiendas.DataBind();
        }

        protected void gvMultitiendas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMultitiendas.PageIndex = e.NewPageIndex;
            CargarMultitiendas();
        }

        protected void BtnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Index.aspx");
        }

        //Metodo para limpiar los campos de los controles
        private void limpiarControl()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Crea una instancia
                Multitienda.Negocio.Categoria cat = new Multitienda.Negocio.Categoria();
                cat.IdCategoria = int.Parse(txtId.Text);

                //Verifica con el metodo si Read si la consulta del metodo retorna true es porque encontro el id existente
                //de lo contrario almacena en la instancia y registra
                if (!cat.Read())
                {
                    cat.Nombre = txtNombre.Text;

                    cat.Create();
                    //Una vez sea creado se llama a cargarMultitiendas() para motras el nuevo registro
                    CargarMultitiendas();

                    lblMensaje.Text = "Categoria creada con exito";
                }
                else
                {
                    lblMensaje.Text = "Id Categoria ya existe";
                    limpiarControl();
                }
            }catch(Exception ex)
            {
                lblMensaje.Text = "No se pudo registrar Categoria";
                limpiarControl();
            }
        }

        protected void gvMultitiendas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}