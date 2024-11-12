namespace BaseDeDatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            funcionToolStripMenuItem = new ToolStripMenuItem();
            peliculaToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            clientesMasFrecuentesToolStripMenuItem = new ToolStripMenuItem();
            horarioMasPopularToolStripMenuItem = new ToolStripMenuItem();
            reservasCanceladasToolStripMenuItem = new ToolStripMenuItem();
            generosMasPopularesToolStripMenuItem = new ToolStripMenuItem();
            gananciasXDiaToolStripMenuItem = new ToolStripMenuItem();
            integrantesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultarToolStripMenuItem, integrantesToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionToolStripMenuItem, peliculaToolStripMenuItem });
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(54, 20);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // funcionToolStripMenuItem
            // 
            funcionToolStripMenuItem.Name = "funcionToolStripMenuItem";
            funcionToolStripMenuItem.Size = new Size(117, 22);
            funcionToolStripMenuItem.Text = "Funcion";
            funcionToolStripMenuItem.Click += funcionToolStripMenuItem_Click;
            // 
            // peliculaToolStripMenuItem
            // 
            peliculaToolStripMenuItem.Name = "peliculaToolStripMenuItem";
            peliculaToolStripMenuItem.Size = new Size(117, 22);
            peliculaToolStripMenuItem.Text = "Pelicula";
            peliculaToolStripMenuItem.Click += peliculaToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesMasFrecuentesToolStripMenuItem, horarioMasPopularToolStripMenuItem, reservasCanceladasToolStripMenuItem, generosMasPopularesToolStripMenuItem, gananciasXDiaToolStripMenuItem });
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(70, 20);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clientesMasFrecuentesToolStripMenuItem
            // 
            clientesMasFrecuentesToolStripMenuItem.Name = "clientesMasFrecuentesToolStripMenuItem";
            clientesMasFrecuentesToolStripMenuItem.Size = new Size(200, 22);
            clientesMasFrecuentesToolStripMenuItem.Text = "Clientes mas frecuentes";
            clientesMasFrecuentesToolStripMenuItem.Click += clientesMasFrecuentesToolStripMenuItem_Click;
            // 
            // horarioMasPopularToolStripMenuItem
            // 
            horarioMasPopularToolStripMenuItem.Name = "horarioMasPopularToolStripMenuItem";
            horarioMasPopularToolStripMenuItem.Size = new Size(200, 22);
            horarioMasPopularToolStripMenuItem.Text = "Horario mas popular";
            horarioMasPopularToolStripMenuItem.Click += horarioMasPopularToolStripMenuItem_Click;
            // 
            // reservasCanceladasToolStripMenuItem
            // 
            reservasCanceladasToolStripMenuItem.Name = "reservasCanceladasToolStripMenuItem";
            reservasCanceladasToolStripMenuItem.Size = new Size(200, 22);
            reservasCanceladasToolStripMenuItem.Text = "Asientos Populares";
            reservasCanceladasToolStripMenuItem.Click += reservasCanceladasToolStripMenuItem_Click;
            // 
            // generosMasPopularesToolStripMenuItem
            // 
            generosMasPopularesToolStripMenuItem.Name = "generosMasPopularesToolStripMenuItem";
            generosMasPopularesToolStripMenuItem.Size = new Size(200, 22);
            generosMasPopularesToolStripMenuItem.Text = "Peliculas mas populares";
            generosMasPopularesToolStripMenuItem.Click += generosMasPopularesToolStripMenuItem_Click;
            // 
            // gananciasXDiaToolStripMenuItem
            // 
            gananciasXDiaToolStripMenuItem.Name = "gananciasXDiaToolStripMenuItem";
            gananciasXDiaToolStripMenuItem.Size = new Size(200, 22);
            gananciasXDiaToolStripMenuItem.Text = "Ganancias x dia";
            // 
            // integrantesToolStripMenuItem
            // 
            integrantesToolStripMenuItem.Name = "integrantesToolStripMenuItem";
            integrantesToolStripMenuItem.Size = new Size(78, 20);
            integrantesToolStripMenuItem.Text = "Integrantes";
            integrantesToolStripMenuItem.Click += integrantesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem funcionToolStripMenuItem;
        private ToolStripMenuItem peliculaToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem clientesMasFrecuentesToolStripMenuItem;
        private ToolStripMenuItem horarioMasPopularToolStripMenuItem;
        private ToolStripMenuItem generosMasPopularesToolStripMenuItem;
        private ToolStripMenuItem reservasCanceladasToolStripMenuItem;
        private ToolStripMenuItem gananciasXDiaToolStripMenuItem;
        private ToolStripMenuItem integrantesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}
