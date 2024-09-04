using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Multitienda.Negocio
{
    public class Categoria : IPersistente
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }

        public Categoria()
        {
            this.Init();
        }
        private void Init()
        {
            IdCategoria = 0;
            Nombre = string.Empty;
        }

        //crear una instancia de la entidad, poblar las propiedades con sus valores de estado,
        //agregar la instancia al modelo y solicitar que se guarden los cambios
        public bool Create()
        {
            Multitienda.DALC.Categoria cat = new DALC.Categoria();
            try
            {
                cat.IdCategoria = this.IdCategoria;
                cat.nombre = this.Nombre;

                CommonBC.ModeloMultitienda.Categoria.Add(cat);
                CommonBC.ModeloMultitienda.SaveChanges();

                return true;
            }catch(Exception ex)
            {
                CommonBC.ModeloMultitienda.Entry(cat).State = System.Data.EntityState.Detached;
                return false;
            }
        }
        //recupa la instancia desde el EDM y poblar sus valores de estado desde las propiedades de la entidad
        public bool Read()
        {
            try
            {
                Multitienda.DALC.Categoria categoria = CommonBC.ModeloMultitienda.Categoria.First(cat => cat.IdCategoria == this.IdCategoria);

                this.Nombre = categoria.nombre;

                return true;
            }catch(Exception ex)
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
                Multitienda.DALC.Categoria categoriaModificada = CommonBC.ModeloMultitienda.Categoria.First(cat => cat.IdCategoria == this.IdCategoria);

                categoriaModificada.nombre = this.Nombre;

                CommonBC.ModeloMultitienda.SaveChanges();
                return true;
            }catch(Exception ex)
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
                Multitienda.DALC.Categoria categoriaEliminar = CommonBC.ModeloMultitienda.Categoria.First(cat => cat.IdCategoria == this.IdCategoria);

                CommonBC.ModeloMultitienda.Categoria.Remove(categoriaEliminar);
                CommonBC.ModeloMultitienda.SaveChanges();
                return true;

            }catch(Exception ex)
            {
                return false;
            }
        }
        
        

    }
}
