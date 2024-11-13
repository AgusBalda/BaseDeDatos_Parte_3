using BaseDeDatos.Datos;
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
    public partial class FrmGananciaxdia : Form
    {
        AccesoDatos oBD = new AccesoDatos();
        public FrmGananciaxdia()
        {
            InitializeComponent();
        }

        private void FrmGananciaxdia_Load(object sender, EventArgs e)
        {

        }
        public void CargarGrilla(string consultaSQL)
        {
            DataTable tabla = oBD.consultarBD(consultaSQL);

            dgvGanancia.DataSource = tabla;


        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string ConsultaSQL= "select f.dia, sum(precio - precio * coalesce(p.desc_porcentaje,0)/100) * count(t.id_ticket) 'Ganancia por Dia'\r\nfrom Funciones f\r\nfull join Promociones p on p.cod_promocion = f.cod_promocion\r\njoin tickets t on t.cod_funcion = f.cod_funcion\r\ngroup by f.dia\r\norder by dia";
            CargarGrilla(ConsultaSQL);
        }

    }
}
