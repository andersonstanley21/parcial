using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeProductos.ENTIDADES;

namespace VentaDeProductos.NEGOCIO
{
    class ClsUsuario
    {
        public int usu=0;
        public string ACCESO(usuario usuario)//NOMBRE DE USUARIO ES "ANDER"
        {
            if (usuario.Nombre1 == "ANDER" && usuario.Contraseña1 == 123) 
            {
                usu = usu + 1;

                return "INICIO DE  SESIÓN CORRECTO PUEDES CONTINUAR CON EL PROCESO DE VENTA";


            }
            else
            {
                usu = usu +  2;
                return "error ingrese los datos correctos";

            }


        }
                
                   
    }
}
