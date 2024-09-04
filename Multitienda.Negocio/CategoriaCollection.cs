using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitienda.Negocio
{
    public class CategoriaCollection
    {
        //Metodo ReadAll para proveer de registros a un GridView este metodo retorna una lista completa de entidades
        public List<Categoria> ReadAll()
        {
            var categorias = CommonBC.ModeloMultitienda.Categoria;

            return GenerarListado(categorias.ToList());
        }


        //Metodo para generar un listado completo de Categorias
        private List<Categoria> GenerarListado(List<Multitienda.DALC.Categoria> multitiendaDALC)
        {
            List<Multitienda.Negocio.Categoria> multitiendas = new List<Categoria>();

            foreach(Multitienda.DALC.Categoria cat in multitiendaDALC)
            {
                Multitienda.Negocio.Categoria multitienda = new Categoria();

                multitienda.IdCategoria = cat.IdCategoria;
                multitienda.Nombre = cat.nombre;

                multitiendas.Add(multitienda);
            }
            return multitiendas;
        }
    }
}
