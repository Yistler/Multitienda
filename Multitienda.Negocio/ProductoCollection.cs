using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitienda.Negocio
{
    public class ProductoCollection
    {

        //Metodo ReadAll para proveer de registros a un GridView este metodo retorna una lista completa de entidades
        public List<Producto> ReadAll()
        {
            var productos = CommonBC.ModeloMultitienda.Producto;

            return GenerarListado(productos.ToList());
        }


        //Metodo para generar un listado completo de Categorias
        private List<Producto> GenerarListado(List<Multitienda.DALC.Producto> multitiendaDALC)
        {
            List<Multitienda.Negocio.Producto> multitiendas = new List<Producto>();

            foreach (Multitienda.DALC.Producto pro in multitiendaDALC)
            {
                Multitienda.Negocio.Producto multitienda = new Producto();

                multitienda.idProducto = pro.idProducto;
                multitienda.Nombre = pro.Nombre;
                multitienda.Descripcion = pro.Descripcion;
                multitienda.idCategoria = pro.idCategoria;

                multitiendas.Add(multitienda);
            }
            return multitiendas;
        }
    }
}
