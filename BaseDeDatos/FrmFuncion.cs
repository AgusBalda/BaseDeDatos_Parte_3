using BaseDeDatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class FrmFuncion : Form
    {
        private cineContext _context;
        public FrmFuncion(cineContext cineContext)
        {
            _context = cineContext;
            InitializeComponent();
            //combo de peli
            List<Pelicula> lpeli = _context.Peliculas.ToList();
            cboPeli.DataSource = lpeli;
            cboPeli.DisplayMember = "Titulo";
            cboPeli.ValueMember = "CodPelicula";
            cboPeli.SelectedIndex = -1;
            cboPeli.DropDownStyle = ComboBoxStyle.DropDownList;
            //combo de sala
            List<Sala> lsala = _context.Salas.ToList();
            cboSala.DataSource = lsala;
            cboSala.DisplayMember = "NroSala";
            cboSala.ValueMember = "IdSala";
            cboSala.SelectedIndex = -1;
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            //combo tipo Funcion
            List<TiposFuncion> ltf = _context.TiposFuncions.ToList();
            cboFuncion.DataSource = ltf;
            cboFuncion.DisplayMember = "Tipo";
            cboFuncion.ValueMember = "IdTipoFuncion";
            cboFuncion.SelectedIndex = -1;
            cboFuncion.DropDownStyle = ComboBoxStyle.DropDownList;
            //combo Promocion
            List<Promocione> lpromo = _context.Promociones.ToList();
            cboPromo.DataSource = lpromo;
            cboPromo.DisplayMember = "DescPorcentaje";
            cboPromo.ValueMember = "CodPromocion";
            cboPromo.SelectedIndex = -1;
            cboPromo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmFuncion_Load(object sender, EventArgs e)
        {
            //Esto es para que me muestre horas en vez de fecha. Ya que el dtp tira siempre una fecha
            dtphorainicio.Format = DateTimePickerFormat.Time;
            dtphorainicio.CustomFormat = "HH:mm";
            dtphorainicio.ShowUpDown = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Funcione cFunciones = new Funcione();
                cFunciones.Dia = DateOnly.FromDateTime(dtpDia.Value);
                cFunciones.HoraInicio = TimeOnly.FromDateTime(dtphorainicio.Value); //toma solo la hora 
                cFunciones.Precio = Convert.ToInt32(txtPrecio.Text);
                cFunciones.CodPelicula = Convert.ToInt32(cboPeli.SelectedValue);
                cFunciones.IdSala = Convert.ToInt32(cboSala.SelectedValue);
                cFunciones.IdTipoFuncion = Convert.ToInt32(cboFuncion.SelectedValue);
                cFunciones.CodPromocion = Convert.ToInt32(cboPromo.SelectedValue);
                _context.Funciones.Add(cFunciones);
                if (_context.SaveChanges() == 1)
                {
                    MessageBox.Show("Funcion agregada", "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Funcion NO agregada, intente de nuevo", "NO AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private bool Validar()
        {
            bool valid = true;
            //if (txtDia.Text == string.Empty)
            //{
            //    valid = false;
            //    MessageBox.Show("Ingrese un día", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //}
            if (txtPrecio.Text == string.Empty)
            {
                valid = false;
                MessageBox.Show("Ingrese un precio", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboPeli.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Ingrese una peli", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboSala.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Ingrese una sala", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboFuncion.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Ingrese una funcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboPromo.SelectedIndex == -1)
            {
                valid = false;
                MessageBox.Show("Ingrese una promo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valid;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
