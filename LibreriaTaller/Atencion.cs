using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaller
{
    public class Atencion
    {
        private int codigo;
        private string nombre;
        private List<Insumo> insumos;
        private int horasHombre;
        private int valorHoraHombre;

        public Atencion(int codigo, string nombre, int horasHombre)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.HorasHombre = horasHombre;
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
        public List<Insumo> Insumos { get => insumos;}


       
        //Validar que el valor de las horas hombre  sea mayor a 0
        public int HorasHombre { get => horasHombre; set => horasHombre = value; }

        
        /// <summary>
        /// Agrega un insumo si este no se encuentra en la lista
        /// </summary>
        /// <param name="nuevo">El nuevo insumo a agregar</param>
        public void AgregarInsumo(Insumo nuevo)
        {
            bool existe = false;
            foreach(Insumo i in insumos)
            {
                if(i.Codigo==nuevo.Codigo)
                {
                    existe = true;
                    break;
                }
            }

            //Si no existe lo agrega
            if(!existe)
            {
                throw new ArgumentException("El nuevo insumo ya existe");
            }
            else
            {
                insumos.Add(nuevo);
            }
        }
    }
}