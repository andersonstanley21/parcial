using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeProductos.ENTIDADES
{
    class ventas
    {
        private int id_del_Producto;
        private string nombre_del_producto;
        private string descripcion_del_producto;
        private double precio_del_producto;
        private int cantidad_del_producto;

        public ventas(int id_del_Producto, string nombre_del_producto, string descripcion_del_producto, double precio_del_producto, int cantidad_del_producto)
        {
            this.Id_del_Producto = id_del_Producto;
            this.Nombre_del_producto = nombre_del_producto;
            this.Descripcion_del_producto = descripcion_del_producto;
            this.Precio_del_producto = precio_del_producto;
            this.Cantidad_del_producto = cantidad_del_producto;
        }

        public int Id_del_Producto { get => id_del_Producto; set => id_del_Producto = value; }
        public string Nombre_del_producto { get => nombre_del_producto; set => nombre_del_producto = value; }
        public string Descripcion_del_producto { get => descripcion_del_producto; set => descripcion_del_producto = value; }
        public double Precio_del_producto { get => precio_del_producto; set => precio_del_producto = value; }
        public int Cantidad_del_producto { get => cantidad_del_producto; set => cantidad_del_producto = value; }
    }
}
