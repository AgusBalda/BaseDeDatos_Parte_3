namespace BaseDeDatos
{
    partial class NuevoPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BtnAgregar = new Button();
            BtnCanselar = new Button();
            textTitulo = new TextBox();
            dtpFechaEstreno = new DateTimePicker();
            nupDuracion = new NumericUpDown();
            cboGenero = new ComboBox();
            cboClasificacion = new ComboBox();
            cboDirector = new ComboBox();
            cboIdioma = new ComboBox();
            lblTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nupDuracion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(12, 210);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(105, 35);
            BtnAgregar.TabIndex = 0;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += button1_Click;
            // 
            // BtnCanselar
            // 
            BtnCanselar.Location = new Point(484, 210);
            BtnCanselar.Name = "BtnCanselar";
            BtnCanselar.Size = new Size(105, 35);
            BtnCanselar.TabIndex = 1;
            BtnCanselar.Text = "Cancelar";
            BtnCanselar.UseVisualStyleBackColor = true;
            BtnCanselar.Click += BtnCanselar_Click;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(71, 25);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(193, 23);
            textTitulo.TabIndex = 2;
            textTitulo.TextChanged += textTitulo_TextChanged;
            // 
            // dtpFechaEstreno
            // 
            dtpFechaEstreno.Location = new Point(71, 71);
            dtpFechaEstreno.Name = "dtpFechaEstreno";
            dtpFechaEstreno.Size = new Size(193, 23);
            dtpFechaEstreno.TabIndex = 4;
            // 
            // nupDuracion
            // 
            nupDuracion.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            nupDuracion.Location = new Point(71, 118);
            nupDuracion.Maximum = new decimal(new int[] { 450, 0, 0, 0 });
            nupDuracion.Name = "nupDuracion";
            nupDuracion.Size = new Size(193, 23);
            nupDuracion.TabIndex = 5;
            nupDuracion.ValueChanged += nupDuracion_ValueChanged;
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(366, 25);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(193, 23);
            cboGenero.TabIndex = 6;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(366, 71);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(193, 23);
            cboClasificacion.TabIndex = 7;
            cboClasificacion.SelectedIndexChanged += cboClasificacion_SelectedIndexChanged;
            // 
            // cboDirector
            // 
            cboDirector.FormattingEnabled = true;
            cboDirector.Location = new Point(366, 117);
            cboDirector.Name = "cboDirector";
            cboDirector.Size = new Size(193, 23);
            cboDirector.TabIndex = 8;
            cboDirector.SelectedIndexChanged += cboDirector_SelectedIndexChanged;
            // 
            // cboIdioma
            // 
            cboIdioma.FormattingEnabled = true;
            cboIdioma.Location = new Point(366, 162);
            cboIdioma.Name = "cboIdioma";
            cboIdioma.Size = new Size(193, 23);
            cboIdioma.TabIndex = 9;
            cboIdioma.SelectedIndexChanged += cboIdioma_SelectedIndexChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(27, 28);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 77);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 11;
            label1.Text = "Estreno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 121);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 12;
            label2.Text = "Duracion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 28);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 13;
            label3.Text = "Genero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(286, 77);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 14;
            label4.Text = "Clasificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(311, 121);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 15;
            label5.Text = "Director";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(416, 172);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(316, 165);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 17;
            label7.Text = "Idioma";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // NuevoPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 256);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Controls.Add(cboIdioma);
            Controls.Add(cboDirector);
            Controls.Add(cboClasificacion);
            Controls.Add(cboGenero);
            Controls.Add(nupDuracion);
            Controls.Add(dtpFechaEstreno);
            Controls.Add(textTitulo);
            Controls.Add(BtnCanselar);
            Controls.Add(BtnAgregar);
            Name = "NuevoPelicula";
            Text = "NuevoPelicula";
            Load += NuevoPelicula_Load;
            ((System.ComponentModel.ISupportInitialize)nupDuracion).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAgregar;
        private Button BtnCanselar;
        private TextBox textTitulo;
        private DateTimePicker dtpFechaEstreno;
        private NumericUpDown nupDuracion;
        private ComboBox cboGenero;
        private ComboBox cboClasificacion;
        private ComboBox cboDirector;
        private ComboBox cboIdioma;
        private Label lblTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider1;
    }
}