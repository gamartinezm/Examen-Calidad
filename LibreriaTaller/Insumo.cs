using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaller
{
    public class Insumo
    {
        private int codigo;
        private string nombre;
        private int precio;
        private int stock;

        public Insumo(int codigo, string nombre, int precio, int stock)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre;
            set
            {
                if (value.Trim().Length > 0)
                    this.nombre = value;
                else
                {
                    throw new ArgumentException("El nombre no puede estar en blanco");
                }
            }
                }
        public int Precio { get => precio;
            set
            {
                if(value>0)
                {
                    this.precio = value;
                }
                else
                {
                    throw new ArgumentException("El precio debe ser un valor positivo");
                }
            }
            }
        public int Stock { get => stock;
            set
            {
                if (value >= 0)
                    this.stock = value;
                else
                {
                    throw new ArgumentOutOfRangeException("El valor del stock no puede ser negativo");
                }
            } }

        /// <summary>
        /// Descuenta la cantidad del stock siempre que este sea suficiente
        /// </summary>
        /// <param name="cantidad">La cantidad a descontar del stock</param>
        /// <returns>true si lo puede descontar, sino false</returns>
        public bool DescontarStock(int cantidad)
        {
            bool res = false;

            if((this.stock-cantidad)>=0)
            {
                this.stock -= cantidad;
                res = true;
            }
            else
            {
                throw new ArgumentOutOfRangeException("El valor no se puede descontar porque es mayor que el stock disponible");
            }
            return res;
        }
    }
}