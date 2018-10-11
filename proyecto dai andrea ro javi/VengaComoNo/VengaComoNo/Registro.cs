using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VengaComoNo
{
    class Registro
    {
        //atributos
        public Int16 idRegistro { get; set; }
        public String fecha { get; set; }
        public Int16 monto { get; set; }
        public Int16 cantidad { get; set; }
        public String idProducto { get; set; }

    //constructores
    public Registro( Int16 idRegistro, Int16 monto, Int16 cantidad, String fecha, String idProducto)
        {
            this.idRegistro = idRegistro;
            this.fecha = fecha;
            this.monto = monto;
            this.cantidad = cantidad;
            this.idProducto = idProducto;

        }

        public Registro()
        {

        }

        public Registro(Int16 idRegistro)
        {

        }

        //el registro solo puede tener agregar y buscar por seguridad.
        public int agregaRegistro(Registro r)
        {
            int res = 0;

            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("insert into registro (idRegistro, monto, cantidad, fecha,idProducto) values('{0}', '{1}' , '{2}', '{3}','{4}')", r.idRegistro, r.monto, r.cantidad, r.fecha, r.idProducto), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo agregar el registro " + ex);
            }
            return res;
        }

        public List<Registro> buscarRegistro(Int16 idRegistro)
        {
            List<Registro> lista = new List<Registro>();

            try
            {
                Registro r;

                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("select idRegistro, monto, cantidad, fecha,idProducto from registro where idRegistro = '{0}'", idRegistro), con);
                SqlDataReader dr = cmd.ExecuteReader(); //es mi lector de datos.

                while (dr.Read())
                {
                    r = new Registro();
                    r.idRegistro = dr.GetInt16(0);

                    r.monto = dr.GetInt16(1);
                    r.cantidad = dr.GetInt16(2);
                    r.fecha = dr.GetString(3);
                    r.idProducto = dr.GetString(4);

                    lista.Add(r);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo encontrar el registro " + ex);
            }
            return lista;
        }

    }
}
