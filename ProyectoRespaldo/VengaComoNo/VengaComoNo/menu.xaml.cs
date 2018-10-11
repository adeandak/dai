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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btPat_Click(object sender, RoutedEventArgs e)
        {
            altaPatrocinadores w = new altaPatrocinadores();
            w.Show();
            this.Close();
        }

        private void btProd_Click(object sender, RoutedEventArgs e)
        {
            altaProducto w = new altaProducto();
            w.Show();
            this.Close();
        }

        private void btRegistro_Click(object sender, RoutedEventArgs e)
        {
            altaRegistro w = new altaRegistro();
            w.Show();
            this.Close();
        }
    }
}
