using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebMultitienda
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCategoria_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Categoria.aspx");
        }

        protected void btnProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Producto.aspx");
        }
    }
}