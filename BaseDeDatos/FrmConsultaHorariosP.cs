using BaseDeDatos.Models;
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
    public partial class FrmConsultaHorariosP : Form
    {
        private cineContext _dbContext;
        public FrmConsultaHorariosP(cineContext Context)
        {
            InitializeComponent();
            _dbContext = Context;
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvhorarios.DataSource = null;
            if(cbDia.Checked)
            {
                List<horarios_popularesResult> list = await _dbContext.Procedures.horarios_popularesAsync("Dia");
                DataTable dt = new DataTable();
                dt.Columns.Add("Dia", typeof(string));
                dt.Columns.Add("Horarios", typeof(TimeOnly));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Ganancias", typeof(int));
                foreach (horarios_popularesResult l in list)
                {
                    if (l.Dia == 1)
                    {
                        dt.Rows.Add("Domingo", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 2)
                    {
                        dt.Rows.Add("Lunes", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 3)
                    {
                        dt.Rows.Add("Martes", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 4)
                    {
                        dt.Rows.Add("Miercoles", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 5)
                    {
                        dt.Rows.Add("Jueves", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 6)
                    {
                        dt.Rows.Add("Viernes", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                    if (l.Dia == 7)
                    {
                        dt.Rows.Add("Sabado", l.hora_inicio, l.Compras, l.Ganancias);
                    }
                }
                dgvhorarios.DataSource = dt;
            }
            else if (cbMes.Checked)
            {
                List<horarios_popularesResult> list = await _dbContext.Procedures.horarios_popularesAsync("Mes");
                DataTable dt = new DataTable();
                dt.Columns.Add("Mes", typeof(int));
                dt.Columns.Add("Horarios", typeof(TimeOnly));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Ganancias", typeof(int));
                foreach (horarios_popularesResult l in list)
                {
                    dt.Rows.Add(l.Dia, l.hora_inicio, l.Compras, l.Ganancias);
                }
                dgvhorarios.DataSource = dt;
            }
            else if (cbAno.Checked)
            {
                List<horarios_popularesResult> list = await _dbContext.Procedures.horarios_popularesAsync("Ano");
                DataTable dt = new DataTable();
                dt.Columns.Add("Año", typeof(int));
                dt.Columns.Add("Horarios", typeof(TimeOnly));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Ganancias", typeof(int));
                foreach (horarios_popularesResult l in list)
                {
                    dt.Rows.Add(l.Dia, l.hora_inicio, l.Compras, l.Ganancias);
                }
                dgvhorarios.DataSource = dt;
            }
            else
            {
                List<horarios_popularesResult> list = await _dbContext.Procedures.horarios_popularesAsync("");
                DataTable dt = new DataTable();
                dt.Columns.Add("Todo", typeof(string));
                dt.Columns.Add("Horarios", typeof(TimeOnly));
                dt.Columns.Add("Cantidad", typeof(int));
                dt.Columns.Add("Ganancias", typeof(int));
                foreach (horarios_popularesResult l in list)
                {
                    dt.Rows.Add("----", l.hora_inicio, l.Compras, l.Ganancias);
                }
                dgvhorarios.DataSource = dt;
            }

        }

        private void cbAno_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAno.Checked)
            {
                if (cbMes.Checked)
                {
                    cbMes.Checked = false;
                }
                if (cbDia.Checked)
                {
                    cbDia.Checked = false;
                }
            }
        }

        private void cbMes_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMes.Checked)
            {
                if (cbDia.Checked)
                {
                    cbDia.Checked = false;
                }
                if (cbAno.Checked)
                {
                    cbAno.Checked = false;
                }
            }

        }

        private void cbDia_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDia.Checked) 
            {
                if (cbAno.Checked)
                {
                    cbAno.Checked = false;
                }
                if (cbMes.Checked)
                {
                    cbMes.Checked = false;
                }
            }

        }
    }
}
