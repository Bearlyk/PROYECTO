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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.DgvEstadisticas = new System.Windows.Forms.DataGridView();
            this.ColEstadisticaDato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstadisticaValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvMatriz = new System.Windows.Forms.DataGridView();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 22F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.ForeColor = System.Drawing.Color.White;
            this.LblTitulo.Location = new System.Drawing.Point(34, 20);
            this.LblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(488, 32);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "ESTADISTICAS Y MATRICES";
            // 
            // DgvEstadisticas
            // 
            this.DgvEstadisticas.AllowUserToAddRows = false;
            this.DgvEstadisticas.AllowUserToDeleteRows = false;
            this.DgvEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEstadisticas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DgvEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColEstadisticaDato,
            this.ColEstadisticaValor});
            this.DgvEstadisticas.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold);
            this.DgvEstadisticas.Location = new System.Drawing.Point(34, 65);
            this.DgvEstadisticas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvEstadisticas.MultiSelect = false;
            this.DgvEstadisticas.Name = "DgvEstadisticas";
            this.DgvEstadisticas.ReadOnly = true;
            this.DgvEstadisticas.RowHeadersVisible = false;
            this.DgvEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEstadisticas.Size = new System.Drawing.Size(315, 310);
            this.DgvEstadisticas.TabIndex = 1;
            // 
            // ColEstadisticaDato
            // 
            this.ColEstadisticaDato.HeaderText = "Dato";
            this.ColEstadisticaDato.Name = "ColEstadisticaDato";
            this.ColEstadisticaDato.ReadOnly = true;
            // 
            // ColEstadisticaValor
            // 
            this.ColEstadisticaValor.HeaderText = "Valor";
            this.ColEstadisticaValor.Name = "ColEstadisticaValor";
            this.ColEstadisticaValor.ReadOnly = true;
            // 
            // DgvMatriz
            // 
            this.DgvMatriz.AllowUserToAddRows = false;
            this.DgvMatriz.AllowUserToDeleteRows = false;
            this.DgvMatriz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMatriz.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DgvMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMatriz.Font = new System.Drawing.Font("OCR A Extended", 8F, System.Drawing.FontStyle.Bold);
            this.DgvMatriz.Location = new System.Drawing.Point(368, 65);
            this.DgvMatriz.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvMatriz.MultiSelect = false;
            this.DgvMatriz.Name = "DgvMatriz";
            this.DgvMatriz.ReadOnly = true;
            this.DgvMatriz.RowHeadersVisible = false;
            this.DgvMatriz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMatriz.Size = new System.Drawing.Size(322, 310);
            this.DgvMatriz.TabIndex = 2;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Location = new System.Drawing.Point(51, 390);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(112, 32);
            this.BtnCalcular.TabIndex = 3;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(578, 390);
            this.BtnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(112, 32);
            this.BtnVolver.TabIndex = 4;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // ESTADISTICAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(732, 444);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.DgvMatriz);
            this.Controls.Add(this.DgvEstadisticas);
            this.Controls.Add(this.LblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ESTADISTICAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESTADISTICAS";
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMatriz)).EndInit();
            this.ResumeLayout(false);

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

