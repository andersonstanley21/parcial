using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeProductos.ENTIDADES;

namespace VentaDeProductos.NEGOCIO
{
    class Clsventas
    {
        public string cobrar(ventas Dante21)
        {
            double monto = Dante21.Precio_del_producto * Dante21.Cantidad_del_producto;


            if (Dante21.Precio_del_producto > 50)
            {
                double total = monto - (monto * 0.20);

                Console.WriteLine("con el descuento su precio a pagar es " + total + " precio nor mal es  :" + monto);








            }
            else
                Console.WriteLine("no tiene descuento: " + monto);
            return "";
        }
    }
}