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
    /// Lógica de interacción para modificaProducto.xaml
    /// </summary>
    public partial class modificaProducto : Window
    {
        public modificaProducto()
        {
            InitializeComponent();
        }

        private void btModifica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int res;
                Producto p = new Producto(txtDesc.Text, Int16.Parse(txtId.Text));
                res = p.modificarProducto(p);
                if (res > 0)
                    MessageBox.Show("el producto se modificó");
                else
                    MessageBox.Show("el producto no se modificó");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void btRegresa_Click(object sender, RoutedEventArgs e)
        {
            altaProducto w = new altaProducto();
            w.Show();
            this.Hide();
        }
    }
}
