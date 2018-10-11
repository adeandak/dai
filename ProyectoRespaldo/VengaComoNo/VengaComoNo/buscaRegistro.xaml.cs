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
    /// Interaction logic for buscaRegistro.xaml
    /// </summary>
    public partial class buscaRegistro : Window
    {
        public buscaRegistro()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Registro r = new Registro();
                dgDatos.ItemsSource = r.buscarRegistro(Int16.Parse(tbId.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            altaRegistro w = new altaRegistro();
            w.Show();
            this.Hide();
        }
    }
}
