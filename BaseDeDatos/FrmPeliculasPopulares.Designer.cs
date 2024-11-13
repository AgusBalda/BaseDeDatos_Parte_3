namespace BaseDeDatos
{
    partial class FrmClasificacionesPopulares
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
            dgvConsultar = new DataGridView();
            btnConsultar = new Button();
            lbl1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkATP = new CheckBox();
            chk13 = new CheckBox();
            chk18 = new CheckBox();
            chk21 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).BeginInit();
            SuspendLayout();
            // 
            // lblConsultar
            // 
            lblConsultar.AutoSize = true;
            lblConsultar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsultar.Location = new Point(25, 40);
            lblConsultar.Margin = new Padding(20, 0, 20, 0);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(322, 21);
            lblConsultar.TabIndex = 1;
            lblConsultar.Text = "Peliculas Mas Populares Por Clasificaciones:";
            // 
            // dgvConsultar
            // 
            dgvConsultar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvConsultar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultar.Location = new Point(29, 127);
            dgvConsultar.Name = "dgvConsultar";
            dgvConsultar.Size = new Size(261, 174);
            dgvConsultar.TabIndex = 7;
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultar.Location = new Point(251, 319);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(96, 28);
            btnConsultar.TabIndex = 8;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(29, 85);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(31, 17);
            lbl1.TabIndex = 9;
            lbl1.Text = "ATP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 84);
            label2.Name = "label2";
            label2.Size = new Size(29, 17);
            label2.TabIndex = 10;
            label2.Text = "+13";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 84);
            label3.Name = "label3";
            label3.Size = new Size(29, 17);
            label3.TabIndex = 11;
            label3.Text = "+18";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(293, 84);
            label4.Name = "label4";
            label4.Size = new Size(29, 17);
            label4.TabIndex = 12;
            label4.Text = "+21";
            // 
            // chkATP
            // 
            chkATP.AutoSize = true;
            chkATP.Location = new Point(67, 88);
            chkATP.Name = "chkATP";
            chkATP.Size = new Size(15, 14);
            chkATP.TabIndex = 13;
            chkATP.UseVisualStyleBackColor = true;
            chkATP.CheckedChanged += chkATP_CheckedChanged;
            // 
            // chk13
            // 
            chk13.AutoSize = true;
            chk13.Location = new Point(154, 88);
            chk13.Name = "chk13";
            chk13.Size = new Size(15, 14);
            chk13.TabIndex = 14;
            chk13.UseVisualStyleBackColor = true;
            chk13.CheckedChanged += chk13_CheckedChanged;
            // 
            // chk18
            // 
            chk18.AutoSize = true;
            chk18.Location = new Point(242, 87);
            chk18.Name = "chk18";
            chk18.Size = new Size(15, 14);
            chk18.TabIndex = 15;
            chk18.UseVisualStyleBackColor = true;
            chk18.CheckedChanged += chk18_CheckedChanged;
            // 
            // chk21
            // 
            chk21.AutoSize = true;
            chk21.Location = new Point(332, 88);
            chk21.Name = "chk21";
            chk21.Size = new Size(15, 14);
            chk21.TabIndex = 16;
            chk21.UseVisualStyleBackColor = true;
            chk21.CheckedChanged += chk21_CheckedChanged;
            // 
            // FrmClasificacionesPopulares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 361);
            Controls.Add(chk21);
            Controls.Add(chk18);
            Controls.Add(chk13);
            Controls.Add(chkATP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl1);
            Controls.Add(btnConsultar);
            Controls.Add(dgvConsultar);
            Controls.Add(lblConsultar);
            Name = "FrmClasificacionesPopulares";
            Text = "FrmGenerosPopulares";
            Load += FrmClasificacionesPopulares_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConsultar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConsultar;
        private DataGridView dgvConsultar;
        private Button btnConsultar;
        private Label lbl1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkATP;
        private CheckBox chk13;
        private CheckBox chk18;
        private CheckBox chk21;
    }
}