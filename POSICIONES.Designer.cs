namespace MENU_DE_TORNEOS_1._0
{
    partial class POSICIONES
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
            DgvPosiciones = new System.Windows.Forms.DataGridView();
            ColPosicionPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionPts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPosicionDif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            BtnActualizar = new System.Windows.Forms.Button();
            BtnVolver = new System.Windows.Forms.Button();
            SuspendLayout();
            LblTitulo.BackColor = System.Drawing.Color.Transparent;
            LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 22F, System.Drawing.FontStyle.Bold);
            LblTitulo.ForeColor = System.Drawing.Color.White;
            LblTitulo.Location = new System.Drawing.Point(60, 30);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new System.Drawing.Size(600, 45);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "TABLA DE POSICIONES";
            DgvPosiciones.AllowUserToAddRows = false;
            DgvPosiciones.AllowUserToDeleteRows = false;
            DgvPosiciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvPosiciones.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            DgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColPosicionPos,
            ColPosicionId,
            ColPosicionNombre,
            ColPosicionPts,
            ColPosicionG,
            ColPosicionE,
            ColPosicionP,
            ColPosicionDif});
            DgvPosiciones.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            DgvPosiciones.ForeColor = System.Drawing.Color.Black;
            DgvPosiciones.Location = new System.Drawing.Point(60, 95);
            DgvPosiciones.MultiSelect = false;
            DgvPosiciones.Name = "DgvPosiciones";
            DgvPosiciones.ReadOnly = true;
            DgvPosiciones.RowHeadersVisible = false;
            DgvPosiciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvPosiciones.Size = new System.Drawing.Size(830, 364);
            DgvPosiciones.TabIndex = 1;
            ColPosicionPos.HeaderText = "Pos";
            ColPosicionPos.Name = "ColPosicionPos";
            ColPosicionPos.ReadOnly = true;
            ColPosicionId.HeaderText = "ID";
            ColPosicionId.Name = "ColPosicionId";
            ColPosicionId.ReadOnly = true;
            ColPosicionNombre.HeaderText = "Nombre";
            ColPosicionNombre.Name = "ColPosicionNombre";
            ColPosicionNombre.ReadOnly = true;
            ColPosicionPts.HeaderText = "Pts";
            ColPosicionPts.Name = "ColPosicionPts";
            ColPosicionPts.ReadOnly = true;
            ColPosicionG.HeaderText = "G";
            ColPosicionG.Name = "ColPosicionG";
            ColPosicionG.ReadOnly = true;
            ColPosicionE.HeaderText = "E";
            ColPosicionE.Name = "ColPosicionE";
            ColPosicionE.ReadOnly = true;
            ColPosicionP.HeaderText = "P";
            ColPosicionP.Name = "ColPosicionP";
            ColPosicionP.ReadOnly = true;
            ColPosicionDif.HeaderText = "Dif";
            ColPosicionDif.Name = "ColPosicionDif";
            ColPosicionDif.ReadOnly = true;
            BtnActualizar.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnActualizar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnActualizar.ForeColor = System.Drawing.Color.White;
            BtnActualizar.Location = new System.Drawing.Point(60, 475);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new System.Drawing.Size(150, 40);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "ACTUALIZAR";
            BtnActualizar.UseVisualStyleBackColor = false;
            BtnActualizar.Click += new System.EventHandler(BtnActualizar_Click);
            BtnVolver.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnVolver.ForeColor = System.Drawing.Color.White;
            BtnVolver.Location = new System.Drawing.Point(760, 475);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new System.Drawing.Size(150, 40);
            BtnVolver.TabIndex = 3;
            BtnVolver.Text = "VOLVER";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += new System.EventHandler(BtnVolver_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 18);
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(BtnVolver);
            Controls.Add(BtnActualizar);
            Controls.Add(DgvPosiciones);
            Controls.Add(LblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "POSICIONES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "POSICIONES";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DataGridView DgvPosiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionPts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicionDif;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnVolver;
    }
}

