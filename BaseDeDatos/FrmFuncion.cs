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
            //
        }

        private void FrmFuncion_Load(object sender, EventArgs e)
        {
            //Esto es para que me muestre horas en vez de fecha. Ya que el dtp tira siempre una fecha
            dtphorainicio.Format = DateTimePickerFormat.Time;
            dtphorainicio.CustomFormat = "HH:mm";
            dtphorainicio.ShowUpDown = true;
        }
    }
}
