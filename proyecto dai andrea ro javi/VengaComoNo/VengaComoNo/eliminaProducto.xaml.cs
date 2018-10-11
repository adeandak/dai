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
    /// Lógica de interacción para eliminaProducto.xaml
    /// </summary>
    public partial class eliminaProducto : Window
    {
        public eliminaProducto()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto p = new Producto(Int16.Parse(txtIdBaja.Text));


                int res = p.eliminaProducto(Int16.Parse(txtIdBaja.Text));
                if (res > 0)
                    MessageBox.Show("el producto se elimino");
                else
                    MessageBox.Show("el producto no se elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            altaProducto w = new altaProducto();
            w.Show();
            this.Hide();
        }
    }
}
