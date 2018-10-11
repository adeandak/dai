using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VengaComoNo
{
    class Producto
    {
        //atributos
        public Int16 idProd { get; set; }
        public String nomProd { get; set; }
        public String descProd { get; set; }
        public Int16 costo { get; set; }

        public Int16 precio { get; set; }
        public String idPat { get; set; }

        public Producto(Int16 idProd, String nomProd, String descProd, Int16 costo, Int16 precio, String idPat)
        {
            this.idProd = idProd;
            this.nomProd = nomProd;
            this.descProd = descProd;
            this.costo = costo;
            this.precio = precio;
            this.idPat = idPat;
        }
        public Producto(Int16 idProd)
        {
            this.idProd = idProd;
        }
        public Producto()
        {
         
        }
        public Producto(String desc, Int16 idProd)
        {
            this.descProd = desc;
            this.idProd = idProd;

        }

        public int agregarProducto(Producto p)
        {
            int res = 0;
            /*
            int pat = 0;
            SqlConnection con2;
            con2 = Conexion.agregarConexion();
            SqlCommand patX = new SqlCommand("select idPatrocinador from patrocinador");
            pat = patX.ExecuteNonQuery(); 
                */ //intento de agregar el idPat

            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("insert into producto (idProducto, nombre,descripcion,precioU, costoU, idPatrocinador) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", p.idProd, p.nomProd, p.descProd, p.costo, p.precio, p.idPat), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo agregar el producto" + ex);
            }
            return res;
        }

        public int eliminaProducto(Int16 idProducto)
        {
            int res = 0;
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("delete from producto where idProducto='{0}'", idProducto), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo eliminar el producto" + ex);
            }
            return res;
        }

        public List<Producto> buscarProducto(String nombre) //podriamos agregar un try catch
        {
            List<Producto> lis = new List<Producto>();
            try
            {
                Producto a;
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("select idProducto, nombre,descripcion,precioU, costoU, idPatrocinador from producto where nombre like '%{0}%'", nombre), con);
                SqlDataReader dr = cmd.ExecuteReader(); //AQUI SI TRAIGO DATOS
                while (dr.Read())
                {
                    a = new Producto();
                    a.idProd = dr.GetInt16(0);
                    a.nomProd = dr.GetString(1);
                    a.descProd = dr.GetString(2);
                    a.costo = dr.GetInt16(3);
                    a.precio = dr.GetInt16(4);
                    a.idPat = dr.GetString(5);
                    lis.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo encontrar el producto" + ex);
            }
            return lis;
        }

        public int modificarProducto(Producto p)
        {
            int res = 0;
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("update producto set descripcion ='{0}' where idProducto='{1}'", p.descProd, p.idProd), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo modificar el producto" + ex);
            }
            return res;
        }

    }
}
