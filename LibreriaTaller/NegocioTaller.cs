using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaTaller
{
    public class NegocioTaller
    {
        private List<Atencion> atenciones;
        private List<Cliente> clientes;
        private List<Insumo> insumos;

        public NegocioTaller()
        {
            this.atenciones = new List<Atencion>();
            this.clientes = new List<Cliente>();
            this.insumos = new List<Insumo>();
        }

        public List<Insumo> Insumos { get => insumos; }

        public int AgregarAtencion(Atencion nueva)
        {
            int res = 0;

            return res;
        }

        /// <summary>
        /// Revisa si puede atender a un cliente buscándolo en el registro de clientes
        /// y luego revisa si para cada lista de antenciones se encuentran disponibles los insumos necesarios
        /// </summary>
        /// <param name="atenciones">El listado de atenciones a realizar</param>
        /// <param name="cliente">El cliente que se va a atender</param>
        /// <returns></returns>
        public bool AtenderCliente(List<Atencion> atenciones, Cliente cliente)
        {
            bool res = false;

            return res;
        }

        /// <summary>
        /// Devuelve la lista de todos los insumos faltantes para una atención
        /// </summary>
        /// <param name="atencion">La atención a revisar</param>
        /// <returns>Un listado de insumos faltantes</returns>
        public List<Insumo> InsumosFaltantes(Atencion atencion)
        {
            List<Insumo> lista = new List<Insumo>();

            foreach(Insumo insu in atencion.Insumos)
            {
                if(insu.Stock==0)
                {
                    lista.Add(insu);

                }
            }

            return lista;
        }

        /// <summary>
        /// registra un nuevo cliente en la lista siempre y cuando no exista el rut
        /// </summary>
        /// <returns>un 1 si lo puede agregar</returns>
        public int RegistrarCliente(Cliente nuevo)
        {
            int res = 0;
            bool existe = false;
            foreach(Cliente cli in clientes)
            {
                if(cli.Rut.Equals(nuevo.Rut))
                {
                    existe = false;
                    break;
                }
            }

            if(!existe)
            {
                clientes.Add(nuevo);
                res = 1;
            }
            else
            {
                throw new ArgumentException("El cliente no se puede registrar");
            }

            return res;
        }

        public int RegistrarInsumo(Insumo insumo)
        {
            int res = 0;
            //agrega el insumo a la lista
            //primero revisa si el insumo existe
            insumos.Add(insumo);
            res = 1;

            return res;
        }

        public Insumo BuscarInsumo(int codigo)
        {
            Insumo encontrado = null;

            foreach(Insumo e in insumos)
            {
                if(e.Codigo==codigo)
                {
                    encontrado = e;

                    break;

                }
            }

            return encontrado;
        }
    }
}