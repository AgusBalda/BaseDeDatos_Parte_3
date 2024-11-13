namespace BaseDeDatos
{
    partial class FrmGananciaxdia
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
            dgvGanancia = new DataGridView();
            grbGanancia = new GroupBox();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGanancia).BeginInit();
            grbGanancia.SuspendLayout();
            SuspendLayout();
            // 
            // dgvGanancia
            // 
            dgvGanancia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGanancia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGanancia.Location = new Point(26, 32);
            dgvGanancia.Name = "dgvGanancia";
            dgvGanancia.Size = new Size(347, 265);
            dgvGanancia.TabIndex = 0;
            // 
            // grbGanancia
            // 
            grbGanancia.Controls.Add(btnConsultar);
            grbGanancia.Controls.Add(dgvGanancia);
            grbGanancia.Location = new Point(24, 31);
            grbGanancia.Name = "grbGanancia";
            grbGanancia.Size = new Size(402, 348);
            grbGanancia.TabIndex = 1;
            grbGanancia.TabStop = false;
            grbGanancia.Text = "Ganancia por dia";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(26, 303);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(84, 29);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // FrmGananciaxdia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 391);
            Controls.Add(grbGanancia);
            Name = "FrmGananciaxdia";
            Text = "FrmGananciaxdia";
            Load += FrmGananciaxdia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGanancia).EndInit();
            grbGanancia.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvGanancia;
        private GroupBox grbGanancia;
        private Button btnConsultar;
    }
}