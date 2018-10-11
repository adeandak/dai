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
    /// Lógica de interacción para altaRegistro.xaml
    /// </summary>
    public partial class altaRegistro : Window
    {
        public altaRegistro()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int res;
                Registro r = new Registro(Int16.Parse(txtId.Text), Int16.Parse(txtMonto.Text), Int16.Parse(txtCantidad.Text), txtFecha.Text, txtIdProd.Text);
                res = r.agregaRegistro(r);

                if (res > 0)
                    MessageBox.Show("Se hizo el registro");
                else
                    MessageBox.Show("Hubo un error al hacer el registro");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }

        }

        private void btBuscar_Click(object sender, RoutedEventArgs e)
        {
            buscaRegistro w = new buscaRegistro();
            w.Show();
            this.Close();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }
    }
}
