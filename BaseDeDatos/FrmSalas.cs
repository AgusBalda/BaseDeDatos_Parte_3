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
    public partial class FrmSalas : Form
    {
        cineContext _dbcontext;
        public FrmSalas(cineContext context)
        {
            _dbcontext = context;
            InitializeComponent();
        }

        private void cbSala2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSala2.Checked)
            {
                if (cbSala1.Checked)
                {
                    cbSala1.Checked = false;
                }
                if (cbSala3.Checked)
                {
                    cbSala3.Checked = false;
                }
                if (cbSala4.Checked)
                {
                    cbSala4.Checked = false;
                }
                if (cbSala5.Checked)
                {
                    cbSala5.Checked = false;
                }
                Sala2();
            }
            btnConsultar.Enabled = validar();
        }

        private void cbSala1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSala1.Checked)
            {
                if (cbSala2.Checked)
                {
                    cbSala2.Checked = false;
                }
                if (cbSala3.Checked)
                {
                    cbSala3.Checked = false;
                }
                if (cbSala4.Checked)
                {
                    cbSala4.Checked = false;
                }
                if (cbSala5.Checked)
                {
                    cbSala5.Checked = false;
                }
                Sala1();
            }
            btnConsultar.Enabled = validar();
        }

        private void cbSala3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSala3.Checked)
            {
                if (cbSala2.Checked)
                {
                    cbSala2.Checked = false;
                }
                if (cbSala1.Checked)
                {
                    cbSala1.Checked = false;
                }
                if (cbSala4.Checked)
                {
                    cbSala4.Checked = false;
                }
                if (cbSala5.Checked)
                {
                    cbSala5.Checked = false;
                }
                Sala3();
            }
            btnConsultar.Enabled = validar();
        }

        private void cbSala4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSala4.Checked)
            {
                if (cbSala2.Checked)
                {
                    cbSala2.Checked = false;
                }
                if (cbSala3.Checked)
                {
                    cbSala3.Checked = false;
                }
                if (cbSala1.Checked)
                {
                    cbSala1.Checked = false;
                }
                if (cbSala5.Checked)
                {
                    cbSala5.Checked = false;
                }
                Sala4();
            }
            btnConsultar.Enabled = validar();
        }

        private void cbSala5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSala5.Checked)
            {
                if (cbSala2.Checked)
                {
                    cbSala2.Checked = false;
                }
                if (cbSala3.Checked)
                {
                    cbSala3.Checked = false;
                }
                if (cbSala4.Checked)
                {
                    cbSala4.Checked = false;
                }
                if (cbSala1.Checked)
                {
                    cbSala1.Checked = false;
                }
                Sala5();
            }
            btnConsultar.Enabled = validar();
        }

        private bool validar()
        {
            bool flag = !cbSala1.Checked && !cbSala2.Checked && !cbSala3.Checked && !cbSala4.Checked && !cbSala5.Checked;
            return !flag;
        }

        private void Sala1()
        {
            a11.BackColor = SystemColors.ActiveCaptionText;
            a12.BackColor = SystemColors.ActiveCaptionText;
            a13.BackColor = SystemColors.ActiveCaptionText;
            a14.BackColor = SystemColors.ActiveCaptionText;
            a15.BackColor = SystemColors.ActiveCaptionText;
            a21.BackColor = SystemColors.ActiveCaptionText;
            a22.BackColor = SystemColors.ActiveCaptionText;
            a23.BackColor = SystemColors.ActiveCaptionText;
            a24.BackColor = SystemColors.ActiveCaptionText;
            a25.BackColor = SystemColors.ActiveCaptionText;
            a31.BackColor = SystemColors.HighlightText;
            a32.BackColor = SystemColors.HighlightText;
            a33.BackColor = SystemColors.HighlightText;
            a34.BackColor = SystemColors.HighlightText;
            a35.BackColor = SystemColors.HighlightText;
            a41.BackColor = SystemColors.HighlightText;
            a42.BackColor = SystemColors.HighlightText;
            a43.BackColor = SystemColors.HighlightText;
            a44.BackColor = SystemColors.HighlightText;
            a45.BackColor = SystemColors.HighlightText;
            a51.BackColor = SystemColors.HighlightText;
            a52.BackColor = SystemColors.HighlightText;
            a53.BackColor = SystemColors.HighlightText;
            a54.BackColor = SystemColors.HighlightText;
            a55.BackColor = SystemColors.HighlightText;
            a61.BackColor = SystemColors.HighlightText;
            a62.BackColor = SystemColors.HighlightText;
            a63.BackColor = SystemColors.HighlightText;
            a64.BackColor = SystemColors.HighlightText;
            a65.BackColor = SystemColors.HighlightText;
        }
        private void Sala2()
        {
            a11.BackColor = SystemColors.ActiveCaptionText;
            a12.BackColor = SystemColors.ActiveCaptionText;
            a13.BackColor = SystemColors.ActiveCaptionText;
            a14.BackColor = SystemColors.ActiveCaptionText;
            a15.BackColor = SystemColors.ActiveCaptionText;
            a21.BackColor = SystemColors.ActiveCaptionText;
            a22.BackColor = SystemColors.ActiveCaptionText;
            a23.BackColor = SystemColors.ActiveCaptionText;
            a24.BackColor = SystemColors.ActiveCaptionText;
            a25.BackColor = SystemColors.ActiveCaptionText;
            a31.BackColor = SystemColors.ActiveCaptionText;
            a32.BackColor = SystemColors.ActiveCaptionText;
            a33.BackColor = SystemColors.ActiveCaptionText;
            a34.BackColor = SystemColors.ActiveCaptionText;
            a35.BackColor = SystemColors.ActiveCaptionText;
            a41.BackColor = SystemColors.HighlightText;
            a42.BackColor = SystemColors.HighlightText;
            a43.BackColor = SystemColors.HighlightText;
            a44.BackColor = SystemColors.HighlightText;
            a45.BackColor = SystemColors.HighlightText;
            a51.BackColor = SystemColors.HighlightText;
            a52.BackColor = SystemColors.HighlightText;
            a53.BackColor = SystemColors.HighlightText;
            a54.BackColor = SystemColors.HighlightText;
            a55.BackColor = SystemColors.HighlightText;
            a61.BackColor = SystemColors.HighlightText;
            a62.BackColor = SystemColors.HighlightText;
            a63.BackColor = SystemColors.HighlightText;
            a64.BackColor = SystemColors.HighlightText;
            a65.BackColor = SystemColors.HighlightText;
        }
        private void Sala3()
        {
            a11.BackColor = SystemColors.ActiveCaptionText;
            a12.BackColor = SystemColors.ActiveCaptionText;
            a13.BackColor = SystemColors.ActiveCaptionText;
            a14.BackColor = SystemColors.ActiveCaptionText;
            a15.BackColor = SystemColors.ActiveCaptionText;
            a21.BackColor = SystemColors.ActiveCaptionText;
            a22.BackColor = SystemColors.ActiveCaptionText;
            a23.BackColor = SystemColors.ActiveCaptionText;
            a24.BackColor = SystemColors.ActiveCaptionText;
            a25.BackColor = SystemColors.ActiveCaptionText;
            a31.BackColor = SystemColors.ActiveCaptionText;
            a32.BackColor = SystemColors.ActiveCaptionText;
            a33.BackColor = SystemColors.ActiveCaptionText;
            a34.BackColor = SystemColors.ActiveCaptionText;
            a35.BackColor = SystemColors.ActiveCaptionText;
            a41.BackColor = SystemColors.ActiveCaptionText;
            a42.BackColor = SystemColors.ActiveCaptionText;
            a43.BackColor = SystemColors.ActiveCaptionText;
            a44.BackColor = SystemColors.ActiveCaptionText;
            a45.BackColor = SystemColors.ActiveCaptionText;
            a51.BackColor = SystemColors.HighlightText;
            a52.BackColor = SystemColors.HighlightText;
            a53.BackColor = SystemColors.HighlightText;
            a54.BackColor = SystemColors.HighlightText;
            a55.BackColor = SystemColors.HighlightText;
            a61.BackColor = SystemColors.HighlightText;
            a62.BackColor = SystemColors.HighlightText;
            a63.BackColor = SystemColors.HighlightText;
            a64.BackColor = SystemColors.HighlightText;
            a65.BackColor = SystemColors.HighlightText;
        }
        private void Sala4()
        {
            a11.BackColor = SystemColors.ActiveCaptionText;
            a12.BackColor = SystemColors.ActiveCaptionText;
            a13.BackColor = SystemColors.ActiveCaptionText;
            a14.BackColor = SystemColors.ActiveCaptionText;
            a15.BackColor = SystemColors.ActiveCaptionText;
            a21.BackColor = SystemColors.ActiveCaptionText;
            a22.BackColor = SystemColors.ActiveCaptionText;
            a23.BackColor = SystemColors.ActiveCaptionText;
            a24.BackColor = SystemColors.ActiveCaptionText;
            a25.BackColor = SystemColors.ActiveCaptionText;
            a31.BackColor = SystemColors.ActiveCaptionText;
            a32.BackColor = SystemColors.ActiveCaptionText;
            a33.BackColor = SystemColors.ActiveCaptionText;
            a34.BackColor = SystemColors.ActiveCaptionText;
            a35.BackColor = SystemColors.ActiveCaptionText;
            a41.BackColor = SystemColors.ActiveCaptionText;
            a42.BackColor = SystemColors.ActiveCaptionText;
            a43.BackColor = SystemColors.ActiveCaptionText;
            a44.BackColor = SystemColors.ActiveCaptionText;
            a45.BackColor = SystemColors.ActiveCaptionText;
            a51.BackColor = SystemColors.ActiveCaptionText;
            a52.BackColor = SystemColors.ActiveCaptionText;
            a53.BackColor = SystemColors.ActiveCaptionText;
            a54.BackColor = SystemColors.ActiveCaptionText;
            a55.BackColor = SystemColors.ActiveCaptionText;
            a61.BackColor = SystemColors.HighlightText;
            a62.BackColor = SystemColors.HighlightText;
            a63.BackColor = SystemColors.HighlightText;
            a64.BackColor = SystemColors.HighlightText;
            a65.BackColor = SystemColors.HighlightText;
        }
        private void Sala5()
        {
            a11.BackColor = SystemColors.ActiveCaptionText;
            a12.BackColor = SystemColors.ActiveCaptionText;
            a13.BackColor = SystemColors.ActiveCaptionText;
            a14.BackColor = SystemColors.ActiveCaptionText;
            a15.BackColor = SystemColors.ActiveCaptionText;
            a21.BackColor = SystemColors.ActiveCaptionText;
            a22.BackColor = SystemColors.ActiveCaptionText;
            a23.BackColor = SystemColors.ActiveCaptionText;
            a24.BackColor = SystemColors.ActiveCaptionText;
            a25.BackColor = SystemColors.ActiveCaptionText;
            a31.BackColor = SystemColors.ActiveCaptionText;
            a32.BackColor = SystemColors.ActiveCaptionText;
            a33.BackColor = SystemColors.ActiveCaptionText;
            a34.BackColor = SystemColors.ActiveCaptionText;
            a35.BackColor = SystemColors.ActiveCaptionText;
            a41.BackColor = SystemColors.ActiveCaptionText;
            a42.BackColor = SystemColors.ActiveCaptionText;
            a43.BackColor = SystemColors.ActiveCaptionText;
            a44.BackColor = SystemColors.ActiveCaptionText;
            a45.BackColor = SystemColors.ActiveCaptionText;
            a51.BackColor = SystemColors.ActiveCaptionText;
            a52.BackColor = SystemColors.ActiveCaptionText;
            a53.BackColor = SystemColors.ActiveCaptionText;
            a54.BackColor = SystemColors.ActiveCaptionText;
            a55.BackColor = SystemColors.ActiveCaptionText;
            a61.BackColor = SystemColors.ActiveCaptionText;
            a62.BackColor = SystemColors.ActiveCaptionText;
            a63.BackColor = SystemColors.ActiveCaptionText;
            a64.BackColor = SystemColors.ActiveCaptionText;
            a65.BackColor = SystemColors.ActiveCaptionText;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cbSala1.Checked)
            {
                asientos(1);
            }
            else if (cbSala2.Checked)
            {
                asientos(2);
            }
            else if (cbSala3.Checked)
            {
                asientos(3);
            }
            else if (cbSala4.Checked)
            {
                asientos(4);
            }
            else if (cbSala5.Checked)
            {
                asientos(5);
            }
        }

        private async void asientos(int id)
        {
            List<asientos_popularesResult> listT = await _dbcontext.Procedures.asientos_popularesAsync(id);
            foreach (asientos_popularesResult t in listT)
            {
                string name = "a" + t.fila.ToString() + t.numero.ToString();
                var label = this.Controls.Find(name, true).FirstOrDefault() as Label;

                if (label != null)
                {
                    if (t.count == 1)
                    {
                        label.BackColor = Color.LightCoral;
                    }
                    else if (t.count == 2)
                    {
                        label.BackColor = Color.Firebrick;
                    }
                    else if (t.count == 3)
                    {
                        label.BackColor = Color.Maroon;
                    }
                }
            }
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {

        }
    }
}
