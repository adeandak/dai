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
    /// Lógica de interacción para buscaPatrocinador.xaml
    /// </summary>
    public partial class buscaPatrocinador : Window
    {
        public buscaPatrocinador()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Patrocinador p = new Patrocinador();
                dgDatos.ItemsSource = p.buscarPatrocinador(tbNombre.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            altaPatrocinadores w = new altaPatrocinadores();
            w.Show();
            this.Hide();
        }
    }
}
