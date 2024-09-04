using Multitienda.DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitienda.Negocio
{
    class CommonBC
    {
        // se declara una instancia privada estática del modelo
        private static MultitiendaEntities _modeloMultitienda;


        //el que será accedido mediante una propiedad pública y estática de solo lectura, que verificará el estado de la instancia del modelo.
            public static MultitiendaEntities ModeloMultitienda
        {
            get 
            { 
                if(_modeloMultitienda == null)
                {
                    _modeloMultitienda = new MultitiendaEntities();
                }   
                return _modeloMultitienda; 
            }
        }
        public CommonBC()
        {

        }
    }
}
