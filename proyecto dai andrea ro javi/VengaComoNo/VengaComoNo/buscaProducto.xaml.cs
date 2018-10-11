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
using System.Windows.Shapes;

namespace VengaComoNo
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto p = new Producto();
                dgDatos.ItemsSource = p.buscarProducto(tbNombre.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            altaProducto w = new altaProducto();
            w.Show();
            this.Hide();
       
        }
    }
}
