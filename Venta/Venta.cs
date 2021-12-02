using Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta
{
    public class Venta
    {

        private int numeroV;
        private DateTime fecha;
        

        public void VentaS() { }

        public void VentaD(int num, DateTime fech, Cliente cliente)
        {
            numeroV = num;
            fecha = fech;

        }

            public void setNumeroVenta(int numeroVenta)
            {
                this.numeroV = numeroVenta;
            }

            public int getNumeroVenta()
            {
                return this.numeroV;
            }



            public int getClienteID()
            {
                return this.ClienteID;
            }



        }


    }

}
}
