namespace BaseDeDatos
{
    partial class FrmConsultaHorariosP
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
            label1 = new Label();
            btnConsultar = new Button();
            dgvhorarios = new DataGridView();
            cbAno = new CheckBox();
            cbMes = new CheckBox();
            cbDia = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvhorarios).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "OPCIONES :";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(495, 47);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvhorarios
            // 
            dgvhorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhorarios.Location = new Point(12, 76);
            dgvhorarios.Name = "dgvhorarios";
            dgvhorarios.Size = new Size(558, 293);
            dgvhorarios.TabIndex = 5;
            // 
            // cbAno
            // 
            cbAno.AutoSize = true;
            cbAno.Location = new Point(88, 10);
            cbAno.Name = "cbAno";
            cbAno.Size = new Size(48, 19);
            cbAno.TabIndex = 6;
            cbAno.Text = "Año";
            cbAno.UseVisualStyleBackColor = true;
            cbAno.CheckedChanged += cbAno_CheckedChanged;
            // 
            // cbMes
            // 
            cbMes.AutoSize = true;
            cbMes.Location = new Point(142, 11);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(48, 19);
            cbMes.TabIndex = 7;
            cbMes.Text = "Mes";
            cbMes.UseVisualStyleBackColor = true;
            cbMes.CheckedChanged += cbMes_CheckedChanged;
            // 
            // cbDia
            // 
            cbDia.AutoSize = true;
            cbDia.Location = new Point(196, 11);
            cbDia.Name = "cbDia";
            cbDia.Size = new Size(43, 19);
            cbDia.TabIndex = 8;
            cbDia.Text = "Dia";
            cbDia.UseVisualStyleBackColor = true;
            cbDia.CheckedChanged += cbDia_CheckedChanged;
            // 
            // FrmConsultaHorariosP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 381);
            Controls.Add(cbDia);
            Controls.Add(cbMes);
            Controls.Add(cbAno);
            Controls.Add(dgvhorarios);
            Controls.Add(btnConsultar);
            Controls.Add(label1);
            Name = "FrmConsultaHorariosP";
            Text = "FrmConsultaHorariosP";
            ((System.ComponentModel.ISupportInitialize)dgvhorarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnConsultar;
        private DataGridView dgvhorarios;
        private CheckBox cbAno;
        private CheckBox cbMes;
        private CheckBox cbDia;
    }
}