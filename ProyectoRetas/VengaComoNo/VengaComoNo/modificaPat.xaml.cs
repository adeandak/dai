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
    /// Lógica de interacción para modificaPat.xaml
    /// </summary>
    public partial class modificaPat : Window
    {
        public modificaPat()
        {
            InitializeComponent();
        }

        private void btModifica_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int res;
                Patrocinador p = new Patrocinador(txtMail.Text, txtId.Text);
                res = p.modificarPatrocinador(p);
                if (res > 0)
                    MessageBox.Show("el patrocinador se modificó");
                else
                    MessageBox.Show("el patrocinador no se modificó");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ingresar los datos. " + ex);
            }
        }

        private void btRegresa_Click(object sender, RoutedEventArgs e)
        {
            altaPatrocinadores r= new altaPatrocinadores();
            r.Show();
            this.Hide();
        }
    }
}
