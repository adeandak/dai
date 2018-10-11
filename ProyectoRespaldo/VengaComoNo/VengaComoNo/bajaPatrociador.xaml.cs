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
    /// Lógica de interacción para bajaPatrociador.xaml
    /// </summary>
    public partial class bajaPatrociador : Window
    {
        public bajaPatrociador()
        {
            InitializeComponent();
        }

        private void btBaja_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Patrocinador p = new Patrocinador(txtIdBaja.Text);


                int res = p.eliminaPatrocinador(txtIdBaja.Text);
                if (res > 0)
                    MessageBox.Show("el patricinador se elimino");
                else
                    MessageBox.Show("el patrocinador no se elimino");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }

        }

        private void btRegresar_Click(object sender, RoutedEventArgs e)
        {
            altaPatrocinadores w = new altaPatrocinadores();
            w.Show();
            this.Close();
        }
    }
}
