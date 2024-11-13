namespace BaseDeDatos
{
    partial class FrmClientesFrecuentes
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
            lblConsultar = new Label();
            label1 = new Label();
            label2 = new Label();
            chkAño = new CheckBox();
            chkMes = new CheckBox();
            btnConsultar = new Button();
            dgvConsultar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // lblConsultar
            // 
            lblConsultar.AutoSize = true;
            lblConsultar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultar.Location = new Point(29, 25);
            lblConsultar.Margin = new Padding(20, 0, 20, 0);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(256, 21);
            lblConsultar.TabIndex = 0;
            lblConsultar.Text = "Consultar Clintes Frecunetes  Por :";
            lblConsultar.Click += btnConsultar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 28);
            label1.Name = "label1";
            label1.Size = new Size(33, 17);
            label1.TabIndex = 1;
            label1.Text = "Año";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 31);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // chkAño
            // 
            chkAño.AutoSize = true;
            chkAño.Location = new Point(338, 31);
            chkAño.Name = "chkAño";
            chkAño.Size = new Size(15, 14);
            chkAño.TabIndex = 3;
            chkAño.UseVisualStyleBackColor = true;
            chkAño.CheckedChanged += chkAño_CheckedChanged;
            // 
            // chkMes
            // 
            chkMes.AutoSize = true;
            chkMes.Location = new Point(408, 32);
            chkMes.Name = "chkMes";
            chkMes.Size = new Size(15, 14);
            chkMes.TabIndex = 4;
            chkMes.UseVisualStyleBackColor = true;
            chkMes.CheckedChanged += chkMes_CheckedChanged;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(452, 317);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(96, 28);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvConsultar
            // 
            dgvConsultar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(62, 79);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(444, 208);
            dgvConsultar.TabIndex = 6;
            // 
            // FrmClientesFrecuentes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 373);
            Controls.Add(dgvConsultar);
            Controls.Add(btnConsultar);
            Controls.Add(chkMes);
            Controls.Add(chkAño);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblConsultar);
            Name = "FrmClientesFrecuentes";
            Text = "FrmClientesFrecuentes";
            Load += FrmClientesFrecuentes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultar;
        private Label label1;
        private Label label2;
        private CheckBox chkAño;
        private CheckBox chkMes;
        private Button btnConsultar;
        private DataGridView dgvConsultar;
    }
}