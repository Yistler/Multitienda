using Multitienda.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitienda.Negocio
{
    public class Producto : IPersistente
    {
        public int idProducto {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int idCategoria {  get; set; }

        public Producto()
        {
            this.Init();
        }
        public void Init()
        {
            idProducto = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            idCategoria = 0;

        }

        //Crea una instancia de la entida Producto
        //poblar las propiedades con sus valores de estado
        //agregar la instancia al modelo y solicitar que se guarden los cambios
        //no debes permitir que el usuario ingrese un producto con una categoría que no exista.
        public bool Create()
        {
            Multitienda.DALC.Producto pro = new DALC.Producto();
            try
            {
                //Verifica si la catgoria existe
                bool categoriaExiste = CommonBC.ModeloMultitienda.Categoria.
                    Any(categoria => categoria.IdCategoria == this.idCategoria);
                if( !categoriaExiste )
                {
                    //La categoria no existe
                    Console.WriteLine("Error la categoria no existe");
                    return false;
                }

                pro.idProducto = this.idProducto;
                pro.Nombre = this.Nombre;
                pro.Descripcion = this.Descripcion;
                pro.idCategoria = this.idCategoria;
                CommonBC.ModeloMultitienda.Producto.Add(pro);
                CommonBC.ModeloMultitienda.SaveChanges();
                return true;

            }catch(Exception ex)
            {
                CommonBC.ModeloMultitienda.Entry(pro).State = System.Data.EntityState.Detached;
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }

        //recupa la instancia desde el EDM y poblar sus valores de estado desde las propiedades de la entidad
        public bool Read()
        {
            try
            {
                Multitienda.DALC.Producto producto = CommonBC.ModeloMultitienda.Producto.First(cat => cat.idProducto == this.idProducto);

                this.Nombre = producto.Nombre;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        //Tambien accedemos a la entidad mediante la llave unica del modelo de datos,
        //traspasamos los valores y guardamos los cambios
        public bool Update()
        {
            try
            {
                Multitienda.DALC.Producto productoModificada = CommonBC.ModeloMultitienda.Producto.First(cat => cat.idProducto == this.idProducto);

                productoModificada.Nombre = this.Nombre;

                CommonBC.ModeloMultitienda.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //El método para la operación de eliminación deberá recuperar la instancia de la entidad
        //desde el EDM, para luego solicitar su eliminación y guardar los cambios en el modelo.
        public bool Delete()
        {
            try
            {
                Multitienda.DALC.Producto productoEliminar = CommonBC.ModeloMultitienda.Producto.First(cat => cat.idProducto == this.idProducto);

                CommonBC.ModeloMultitienda.Producto.Remove(productoEliminar);
                CommonBC.ModeloMultitienda.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
