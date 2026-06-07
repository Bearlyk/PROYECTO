namespace MENU_DE_TORNEOS_1._0
{
    partial class ESTADISTICAS
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LblTitulo = new System.Windows.Forms.Label();
            DgvEstadisticas = new System.Windows.Forms.DataGridView();
            DgvMatriz = new System.Windows.Forms.DataGridView();
            ColEstadisticaDato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColEstadisticaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BtnCalcular = new System.Windows.Forms.Button();
            BtnVolver = new System.Windows.Forms.Button();
            SuspendLayout();
            LblTitulo.BackColor = System.Drawing.Color.Transparent;
            LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 22F, System.Drawing.FontStyle.Bold);
            LblTitulo.ForeColor = System.Drawing.Color.White;
            LblTitulo.Location = new System.Drawing.Point(45, 25);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new System.Drawing.Size(650, 40);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "ESTADISTICAS Y MATRICES";
            DgvEstadisticas.AllowUserToAddRows = false;
            DgvEstadisticas.AllowUserToDeleteRows = false;
            DgvEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvEstadisticas.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            DgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvEstadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColEstadisticaDato,
            ColEstadisticaValor});
            DgvEstadisticas.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold);
            DgvEstadisticas.ForeColor = System.Drawing.Color.Black;
            DgvEstadisticas.Location = new System.Drawing.Point(45, 80);
            DgvEstadisticas.MultiSelect = false;
            DgvEstadisticas.Name = "DgvEstadisticas";
            DgvEstadisticas.ReadOnly = true;
            DgvEstadisticas.RowHeadersVisible = false;
            DgvEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvEstadisticas.Size = new System.Drawing.Size(420, 382);
            DgvEstadisticas.TabIndex = 1;
            ColEstadisticaDato.HeaderText = "Dato";
            ColEstadisticaDato.Name = "ColEstadisticaDato";
            ColEstadisticaDato.ReadOnly = true;
            ColEstadisticaValor.HeaderText = "Valor";
            ColEstadisticaValor.Name = "ColEstadisticaValor";
            ColEstadisticaValor.ReadOnly = true;
            DgvMatriz.AllowUserToAddRows = false;
            DgvMatriz.AllowUserToDeleteRows = false;
            DgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvMatriz.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            DgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMatriz.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold);
            DgvMatriz.ForeColor = System.Drawing.Color.Black;
            DgvMatriz.Location = new System.Drawing.Point(490, 80);
            DgvMatriz.MultiSelect = false;
            DgvMatriz.Name = "DgvMatriz";
            DgvMatriz.ReadOnly = true;
            DgvMatriz.RowHeadersVisible = false;
            DgvMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvMatriz.Size = new System.Drawing.Size(430, 382);
            DgvMatriz.TabIndex = 2;
            BtnCalcular.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCalcular.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnCalcular.ForeColor = System.Drawing.Color.White;
            BtnCalcular.Location = new System.Drawing.Point(45, 480);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new System.Drawing.Size(150, 40);
            BtnCalcular.TabIndex = 3;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += new System.EventHandler(BtnCalcular_Click);
            BtnVolver.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnVolver.ForeColor = System.Drawing.Color.White;
            BtnVolver.Location = new System.Drawing.Point(770, 480);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new System.Drawing.Size(150, 40);
            BtnVolver.TabIndex = 4;
            BtnVolver.Text = "VOLVER";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += new System.EventHandler(BtnVolver_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 18);
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(BtnVolver);
            Controls.Add(BtnCalcular);
            Controls.Add(DgvMatriz);
            Controls.Add(DgvEstadisticas);
            Controls.Add(LblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ESTADISTICAS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ESTADISTICAS";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvEstadisticas;
        private System.Windows.Forms.DataGridView DgvMatriz;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstadisticaDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstadisticaValor;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnVolver;
    }
}

