using BaseDeDatos.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace BaseDeDatos
{
    public partial class Form1 : Form
    {
        private readonly cineContext _context;
        public Form1()
        {
            InitializeComponent();

            var optionsBuilder = new DbContextOptionsBuilder<cineContext>();
            optionsBuilder.UseSqlServer(Properties.Resources.ConnectionString);

            _context = new cineContext(optionsBuilder.Options);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reservasCanseladasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de que quiere salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void funcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncion funcion = new FrmFuncion(_context);
            funcion.ShowDialog();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aciar Pablo 114148\r\n\nAlmada Joaquin 412180\r\n\nAraujo Lorenzo  404909\r\n\nBaigorria Dami�n 412085\r\n\nBaldassari Agustin 412082\r\n\nCortez Joaquin 412142", "Integrantes", MessageBoxButtons.OK);
        }

        private void peliculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoPelicula pelicula = new NuevoPelicula(_context);
            pelicula.ShowDialog();
        }
    }
}
