using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VengaComoNo
{
    class Patrocinador
    {
        //atributos
        public String idPatrocinador{ get; set; }
        public String nombre { get; set; }
        public String domicilio { get; set; }
        public String telefono { get; set; }

        public String descripcion { get; set; }
        public String mail { get; set; }



        public Patrocinador(String idPatrocinador, String nombre, String domicilio, String telefono, String descripcion, String mail)
        {
            this.idPatrocinador = idPatrocinador;
            this.nombre = nombre;
            this.domicilio = domicilio;
            this.telefono = telefono;
            this.descripcion = descripcion;
            this.mail = mail;

        }

        public Patrocinador(String idPatrocinador)
        {
            this.idPatrocinador = idPatrocinador;
        }

       
        public Patrocinador()
        {
            
        }

        public Patrocinador(String mail, String idPatrocinador)
        {
            this.mail = mail;
               
            this.idPatrocinador = idPatrocinador;

        } 
        public int agregarPatrocinador(Patrocinador p)
        {
            int res = 0;
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("insert into patrocinador (idPatrocinador, nombre,domicilio,telefono, descripcion, mail) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", p.idPatrocinador, p.nombre, p.domicilio, p.telefono, p.descripcion, p.mail), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo agregar el patrocinador" + ex);
            }
            return res;
        }

        public int eliminaPatrocinador(String idPatrocinador)
        {
            int res = 0;
            try
            {
                SqlConnection con;
                con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("delete from patrocinador where idPatrocinador='{0}'", idPatrocinador), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo eliminar el patrocinador" + ex);
            }

            return res;
        }

        public List<Patrocinador> buscarPatrocinador(String nombre) //podriamos agregar un try catch
        {
            List<Patrocinador> lis = new List<Patrocinador>();
            try
            {
                Patrocinador a;
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("select idPatrocinador, nombre,domicilio,telefono, descripcion, mail from patrocinador where nombre like '%{0}%'", nombre), con);
                SqlDataReader dr = cmd.ExecuteReader(); //AQUI SI TRAIGO DATOS
                while (dr.Read())
                {
                    a = new Patrocinador();
                    a.idPatrocinador = dr.GetString(0);
                    a.nombre = dr.GetString(1);
                    a.domicilio = dr.GetString(2);
                    a.telefono = dr.GetString(3);
                    a.descripcion = dr.GetString(4);
                    a.mail = dr.GetString(5); //sustituye el int
                    lis.Add(a);
                }
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo buscar patrocinadores" + ex);
            }
            return lis;
        }


        public int modificarPatrocinador(Patrocinador p)
        {
            int res = 0;
            try
            {
                SqlConnection con = Conexion.agregarConexion();
                SqlCommand cmd = new SqlCommand(String.Format("update patrocinador set mail ='{0}' where idPatrocinador='{1}'", p.mail, p.idPatrocinador), con);
                res = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show("no se pudo modificar el patrocinador" + ex);
            }
            return res;
        }











    }
}
