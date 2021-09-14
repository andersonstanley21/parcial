using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeProductos.ENTIDADES;
using VentaDeProductos.NEGOCIO;

namespace VentaDeProductos
{
    class Program
    {
        static void Main(string[] args)
        {  
            usuario usuario = new usuario();
            Console.WriteLine("ingrese su nombre de usuario");

            usuario.Nombre1=(Console.ReadLine());
            Console.WriteLine("digite su contraseña");
            usuario.Contraseña1 = Convert.ToInt32(Console.ReadLine());
            ClsUsuario clsUsuario = new ClsUsuario();
            Console.WriteLine(clsUsuario.ACCESO(usuario));
            Console.ReadLine();

            
            
            if(clsUsuario.usu==1)
            {
                Clsventas clsventa = new Clsventas();
                int dante = 1;
                while (dante==1)
                {
                    Console.WriteLine("identifique el producto");

                    int id_del_producto = Convert.ToInt32(Console.ReadLine());



                    Console.WriteLine(" NOMBRE DEL PRODUCTO QUE DESEA COMPRAR");
                    string nombre_del_producto =Console.ReadLine();


                    Console.WriteLine("DESCRIPCION DEL PRODUCTO QUE DESEA COMPRAR");
                    string descripcion_del_producto = Console.ReadLine();

                    Console.WriteLine("PRECIO DEL PRODUCTO QUE DESEA COMPRAR");
                    double precio_del_producto = Convert.ToDouble(Console.ReadLine()); 


                    Console.WriteLine("cantidad del Producto que desea comprar");
                    int cantidad_del_producto = Convert.ToInt32(Console.ReadLine());

                    ventas Dante21 = new ventas(id_del_producto, nombre_del_producto, descripcion_del_producto, precio_del_producto, cantidad_del_producto);
                    Console.WriteLine(clsventa.cobrar(Dante21));
                    Console.ReadLine();
                   






                }








            }

           
          
        }
    }
}
