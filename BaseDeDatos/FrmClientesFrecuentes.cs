using BaseDeDatos.Datos;
using Microsoft.Data.SqlClient;
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
    public partial class FrmClientesFrecuentes : Form
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=tpcine.cn0gmiyiwodt.us-east-2.rds.amazonaws.com;Initial Catalog=tp_cine_bdd;User ID=admin;Encrypt=False");
        AccesoDatos oBD = new AccesoDatos();
        public FrmClientesFrecuentes()
        {
            InitializeComponent();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

            if (chkAño.Checked)
            {
                string consultaSQL = "select top 5 YEAR(t.fecha_compra)'Año',c.apellido+' '+c.nombre Cliente ,count(t.cod_transaccion) 'cantidad de veces que vino'\r\n\t\tfrom clientes c join Transacciones t on t.id_cliente=c.id_cliente\r\n\t\tgroup by YEAR(t.fecha_compra),c.apellido+' '+c.nombre \r\n\t\torder by [cantidad de veces que vino] desc";
                CargarGrilla(consultaSQL);


            }
            else if (chkMes.Checked == true)
            {
                string consultaSQL = "select top 5 YEAR(t.fecha_compra)'Año',month(t.fecha_compra) 'Mes',c.apellido+' '+c.nombre Cliente ,count(t.cod_transaccion) 'cantidad de veces que vino'\r\n\t\tfrom clientes c join Transacciones t on t.id_cliente=c.id_cliente\r\n\t\tgroup by YEAR(t.fecha_compra),month(t.fecha_compra),c.apellido+' '+c.nombre \r\n\t\torder by [cantidad de veces que vino] desc";
                CargarGrilla(consultaSQL);
            }
        }
        public void CargarGrilla(string consultaSQL)
        {
            DataTable tabla = oBD.consultarBD(consultaSQL);

            dgvConsultar.DataSource = tabla;


        }

        private void FrmClientesFrecuentes_Load(object sender, EventArgs e)
        {
            chkAño.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkAño_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAño.Checked == true)
            {
                chkMes.Checked = false;
            }
        }

        private void chkMes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMes.Checked == true)
            {
                chkAño.Checked = false;
            }
        }


    }
}
