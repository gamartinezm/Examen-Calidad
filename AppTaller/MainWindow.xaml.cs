using LibreriaTaller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppTaller
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NegocioTaller nt;

        public MainWindow()
        {
            InitializeComponent();
            nt = new NegocioTaller();
            llenarGrilla();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            int stock = 0;
            int precio = 0;
            int codigo = 0;

            if(!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un valor numérico");
            }


            if(!int.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico");
            }

            if(!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("El stock debe ser un valor positivo");
            }

            if(precio>0 && stock>0 && codigo>0)
            {
                Insumo nuevo = new Insumo(codigo, txtNombre.Text, precio, stock); ;
                if(nt.RegistrarInsumo(nuevo)==1)
                {
                    MessageBox.Show("Insumo agregado sin problemas");
                    llenarGrilla();
                }
                   
            }

        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            int codigo = 0;
            if(txtCodigo.Text.Trim().Length>0)
            {
                int.TryParse(txtCodigo.Text, out codigo);

                Insumo encontrado = nt.BuscarInsumo(codigo);

                if(encontrado!=null)
                {
                    txtCodigo.Text = encontrado.Codigo.ToString();
                    txtNombre.Text = encontrado.Nombre;
                    txtPrecio.Text = encontrado.Precio.ToString();
                    txtStock.Text = encontrado.Stock.ToString();
                }
                
            }
        }

        /// <summary>
        /// LLena la grilla con datos
        /// </summary>
        private void llenarGrilla()
        {
            dgRepuestos.ItemsSource = null;
            dgRepuestos.ItemsSource = nt.Insumos;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
