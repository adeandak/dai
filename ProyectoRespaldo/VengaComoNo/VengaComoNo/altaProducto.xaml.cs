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
    /// Lógica de interacción para altaProducto.xaml
    /// </summary>
    public partial class altaProducto : Window
    {
        public altaProducto()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }

        private void btagregarProd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int res;
                Producto p = new Producto(Int16.Parse(txtIdProd.Text), txtNomProd.Text, txtDescProd.Text, Int16.Parse(txtCosto.Text), Int16.Parse(txtPrecio.Text), txtIdPat.Text);
                res = p.agregarProducto(p);
                if (res > 0)
                    MessageBox.Show("el producto se dio de alta");
                else
                    MessageBox.Show("el producto no se dio de alta");
            }  catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void bteliminarProd_Click(object sender, RoutedEventArgs e)
        {
            eliminaProducto w = new VengaComoNo.eliminaProducto(); 
            w.Show();
            this.Hide();
        }

        private void btBuscarProd_Click(object sender, RoutedEventArgs e)
        {
            Window1 b = new Window1();
            b.Show();
            this.Hide();
        }

        private void btModificarProd_Click(object sender, RoutedEventArgs e)
        {
            modificaProducto w = new modificaProducto();
            w.Show();
            this.Hide();

        }
    }
}
