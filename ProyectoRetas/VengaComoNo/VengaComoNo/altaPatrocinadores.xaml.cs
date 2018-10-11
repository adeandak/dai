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
    /// Lógica de interacción para altaPatrocinadores.xaml
    /// </summary>
    public partial class altaPatrocinadores : Window
    {
        public altaPatrocinadores()
        {
            InitializeComponent();
        }

        private void btagregar_Click(object sender, RoutedEventArgs e)
        {
            int res=0;
            try
            {
                Patrocinador p = new Patrocinador(txtId.Text, txtNombre.Text, txtDomicilio.Text, txtTelefono.Text, txtDescripcion.Text, txtMail.Text);
                res = p.agregarPatrocinador(p);
                if (res > 0)
                    MessageBox.Show("el patrocinador se dio de alta");
                else
                    MessageBox.Show("el patrocinador no se dio de alta");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }

        }

        private void bteliminar_Click(object sender, RoutedEventArgs e)
        {
            bajaPatrociador w = new VengaComoNo.bajaPatrociador(); //notar que escribimos PATROCIADOR Y NO PATROCINADOR
            w.Show();
            this.Hide();
        }

        private void btbuscar_Click(object sender, RoutedEventArgs e)
        {
            buscaPatrocinador b = new buscaPatrocinador();
            b.Show();
            this.Hide();
         
            
        }

        private void btmodificar_Click(object sender, RoutedEventArgs e)
        {
            modificaPat w = new modificaPat();
            w.Show();
            this.Hide();
        }

        private void btsalir_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.Show();
            this.Close();
        }
    }
}
