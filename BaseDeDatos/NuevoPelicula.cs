using BaseDeDatos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace BaseDeDatos
{
    public partial class NuevoPelicula : Form
    {
        private cineContext _context;
        public NuevoPelicula(cineContext context)
        { 
            // agregar comentario 
            _context = context;
            InitializeComponent();
            List<Genero> lGeneros = _context.Generos.ToList();
            cboGenero.DataSource = lGeneros;
            cboGenero.DisplayMember = "Genero1";
            cboGenero.ValueMember = "IdGenero";
            cboGenero.SelectedIndex = -1;
            List<Directore> lDirec = _context.Directores.ToList();
            cboDirector.DataSource = lDirec;
            cboDirector.DisplayMember = "Apellido";
            cboDirector.ValueMember = "IdDirector";
            cboDirector.SelectedIndex = -1;
            List<ClasificacionesEdad> lClas = _context.ClasificacionesEdads.ToList();
            cboClasificacion.DataSource = lClas;
            cboClasificacion.DisplayMember = "Clasificacion";
            cboClasificacion.ValueMember = "IdClasificacion";
            cboClasificacion.SelectedIndex = -1;
            List<Idioma> lIdioma = _context.Idiomas.ToList();
            cboIdioma.DataSource = lIdioma;
            cboIdioma.DisplayMember = "Idioma1";
            cboIdioma.ValueMember = "IdIdioma";
            cboIdioma.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pelicula nPelicula = new Pelicula();
            nPelicula.Titulo = textTitulo.Text;
            nPelicula.FechaEstreno = dtpFechaEstreno.Value;
            nPelicula.DuracionMin = Convert.ToInt32(nupDuracion.Value);
            nPelicula.IdGenero = Convert.ToInt32(cboGenero.SelectedValue);
            nPelicula.IdClasificacion = Convert.ToInt32(cboClasificacion.SelectedValue);
            nPelicula.IdDirector = Convert.ToInt32(cboDirector.SelectedValue);
            nPelicula.IdIdioma = Convert.ToInt32(cboIdioma.SelectedValue);
            _context.Peliculas.Add(nPelicula);
            if (_context.SaveChanges() == 1)
            {
                MessageBox.Show("Pelicula agregada", "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Pelicula NO agregada", "NO AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void validar()
        {
            bool flag = true;
            if (textTitulo.Text == string.Empty)
            {
                flag = false;
            }
            if (nupDuracion.Value == 0)
            {
                flag = false;
            }
            if (cboGenero.SelectedIndex == -1)
            {
                flag = false;
            }
            if (cboClasificacion.SelectedIndex == -1)
            {
                flag = false;
            }
            if (cboDirector.SelectedIndex == -1)
            {
                flag = false;
            }
            if (cboIdioma.SelectedIndex == -1)
            {
                flag = false;
            }
            BtnAgregar.Enabled = flag;
        }

        private void textTitulo_TextChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void nupDuracion_ValueChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cboClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cboDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void cboIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            validar();
        }

        private void BtnCanselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
