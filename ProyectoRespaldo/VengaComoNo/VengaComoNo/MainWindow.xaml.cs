using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VengaComoNo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader dr;
            SqlConnection con;
            try
            {
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("select contra from usuarios where idUsuario = '{0}'", txtUsuario.Text), con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr.GetString(0).Equals(txtPassword.Text))
                    {
                        /*ESTA EN CONSIDERACION UNA VISTA EXTRA QUE PREGUNTE QUE VENTANA SE QUIERE ABRIR
                        altaPatrocinadores w = new altaPatrocinadores();
                        altaProducto w2 = new altaProducto();
                        altaRegistro w3 = new altaRegistro();
                        w.Show();
                        w2.Show();
                        w3.Show();
                        this.Close();
                        */
                        Window2 w = new Window2();
                        w.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("contraseña equivocada :)");
                    }
                }
                else
                {
                    MessageBox.Show("usuario equivocado :)");
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex);
            }
        }

        private void btIniciar_Loaded(object sender, RoutedEventArgs e)
        {
            txtUsuario.Text = "rodrigo";
            txtPassword.Text = "ro123";
        }
    }
}
