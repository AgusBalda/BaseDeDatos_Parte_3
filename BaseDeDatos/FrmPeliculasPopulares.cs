using BaseDeDatos.Datos;
using BaseDeDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BaseDeDatos
{
    public partial class FrmClasificacionesPopulares : Form
    {
        AccesoDatos oBD = new AccesoDatos();
        public FrmClasificacionesPopulares()
        {
            InitializeComponent();
        }
        private void FrmClasificacionesPopulares_Load(object sender, EventArgs e)
        {
            chkTodas.Checked = true;
        }
        public void CargarGrilla(string consultaSQL)
        {
            DataTable tabla = oBD.consultarBD(consultaSQL);

            dgvConsultar.DataSource = tabla;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chkATP.Checked)
            {
                string consultaSQL = "SELECT p.titulo AS Pelicula, COUNT(t.id_ticket) 'Tickets Vendidos'\r\nFROM Peliculas p JOIN Funciones f ON p.cod_pelicula = f.cod_pelicula\r\n\t\t\t\t JOIN Tickets t ON f.cod_funcion = t.cod_funcion\r\n\t\t\t\t JOIN Clasificaciones_edad c ON p.id_clasificacion = c.id_clasificacion\r\nWHERE c.clasificacion = 'ATP' \r\nGROUP BY p.titulo\r\nORDER BY 'Tickets Vendidos' DESC";
                CargarGrilla(consultaSQL);
            }
            else if (chk13.Checked)
            {
                string consultaSQL = "SELECT p.titulo AS Pelicula, COUNT(t.id_ticket) 'Tickets Vendidos'\r\nFROM Peliculas p JOIN Funciones f ON p.cod_pelicula = f.cod_pelicula\r\n\t\t\t\t JOIN Tickets t ON f.cod_funcion = t.cod_funcion\r\n\t\t\t\t JOIN Clasificaciones_edad c ON p.id_clasificacion = c.id_clasificacion\r\nWHERE c.clasificacion = '+13' \r\nGROUP BY p.titulo\r\nORDER BY 'Tickets Vendidos' DESC";
                CargarGrilla(consultaSQL);
            }
            else if (chk18.Checked)
            {
                string consultaSQL = "SELECT p.titulo AS Pelicula, COUNT(t.id_ticket) 'Tickets Vendidos'\r\nFROM Peliculas p JOIN Funciones f ON p.cod_pelicula = f.cod_pelicula\r\n\t\t\t\t JOIN Tickets t ON f.cod_funcion = t.cod_funcion\r\n\t\t\t\t JOIN Clasificaciones_edad c ON p.id_clasificacion = c.id_clasificacion\r\nWHERE c.clasificacion = '+18' \r\nGROUP BY p.titulo\r\nORDER BY 'Tickets Vendidos' DESC";
                CargarGrilla(consultaSQL);
            }
            else if (chk21.Checked)
            {
                string consultaSQL = "SELECT p.titulo AS Pelicula, COUNT(t.id_ticket) 'Tickets Vendidos'\r\nFROM Peliculas p JOIN Funciones f ON p.cod_pelicula = f.cod_pelicula\r\n\t\t\t\t JOIN Tickets t ON f.cod_funcion = t.cod_funcion\r\n\t\t\t\t JOIN Clasificaciones_edad c ON p.id_clasificacion = c.id_clasificacion\r\nWHERE c.clasificacion = '+21' \r\nGROUP BY p.titulo\r\nORDER BY 'Tickets Vendidos' DESC";
                CargarGrilla(consultaSQL);
                MessageBox.Show("No hay registros", "Consulta Por +21", MessageBoxButtons.OK);
            }

            else if (chkATP.Checked == false && chk13.Checked == false && chk18.Checked == false && chk21.Checked == false && chkTodas.Checked == false)
            {
                MessageBox.Show("Debe activar una clasificacion por favor!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (chkTodas.Checked)
            {
                string consultaSQL = "SELECT p.titulo AS Pelicula, COUNT(t.id_ticket) 'Tickets Vendidos'\r\nFROM Peliculas p JOIN Funciones f ON p.cod_pelicula = f.cod_pelicula\r\nJOIN Tickets t ON f.cod_funcion = t.cod_funcion JOIN Clasificaciones_edad c ON p.id_clasificacion = c.id_clasificacion\r\nGROUP BY p.titulo \r\nORDER BY 'Tickets Vendidos' DESC";
                CargarGrilla(consultaSQL);
            }
        }

        private void chkATP_CheckedChanged(object sender, EventArgs e)
        {
            if (chkATP.Checked)
            {
                chk21.Checked = false;
                chk18.Checked = false;
                chk13.Checked = false;
                chkTodas.Checked = false;
            }
        }

        private void chk13_CheckedChanged(object sender, EventArgs e)
        {
            if (chk13.Checked)
            {
                chk21.Checked = false;
                chk18.Checked = false;
                chkATP.Checked = false;
                chkTodas.Checked = false;
            }
        }

        private void chk18_CheckedChanged(object sender, EventArgs e)
        {
            if (chk18.Checked)
            {
                chk21.Checked = false;
                chkATP.Checked = false;
                chk13.Checked = false;
                chkTodas.Checked = false;
            }
        }

        private void chk21_CheckedChanged(object sender, EventArgs e)
        {
            if (chk21.Checked)
            {
                chkATP.Checked = false;
                chk18.Checked = false;
                chk13.Checked = false;
                chkTodas.Checked=false;
            }
        }



        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void chkTodas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodas.Checked)
            {
                chk21.Checked = false;
                chkATP.Checked = false;
                chk13.Checked = false;
                chk18.Checked = false;
            }
        }
    }
}
