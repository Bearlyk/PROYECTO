namespace MENU_DE_TORNEOS_1._0
{
    partial class JUGADORES
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JUGADORES));
            TxtNom = new System.Windows.Forms.TextBox();
            BtnRegistrarJu = new System.Windows.Forms.Button();
            BtnEliminarJu = new System.Windows.Forms.Button();
            BtnBuscarJu = new System.Windows.Forms.Button();
            BtnVolverJu = new System.Windows.Forms.Button();
            TxtApo = new System.Windows.Forms.TextBox();
            LblNombre = new System.Windows.Forms.Label();
            LblApodo = new System.Windows.Forms.Label();
            DgvJugadores = new System.Windows.Forms.DataGridView();
            ColJugadorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColJugadorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColJugadorApodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColJugadorPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SuspendLayout();
            TxtNom.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtNom.Location = new System.Drawing.Point(71, 33);
            TxtNom.Name = "TxtNom";
            TxtNom.Size = new System.Drawing.Size(204, 45);
            TxtNom.TabIndex = 0;
            BtnRegistrarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarJu.BackgroundImage")));
            BtnRegistrarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            BtnRegistrarJu.Location = new System.Drawing.Point(707, 26);
            BtnRegistrarJu.Name = "BtnRegistrarJu";
            BtnRegistrarJu.Size = new System.Drawing.Size(186, 52);
            BtnRegistrarJu.TabIndex = 1;
            BtnRegistrarJu.UseVisualStyleBackColor = true;
            BtnEliminarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarJu.BackgroundImage")));
            BtnEliminarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            BtnEliminarJu.Location = new System.Drawing.Point(707, 131);
            BtnEliminarJu.Name = "BtnEliminarJu";
            BtnEliminarJu.Size = new System.Drawing.Size(186, 52);
            BtnEliminarJu.TabIndex = 2;
            BtnEliminarJu.UseVisualStyleBackColor = true;
            BtnBuscarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarJu.BackgroundImage")));
            BtnBuscarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            BtnBuscarJu.Location = new System.Drawing.Point(707, 233);
            BtnBuscarJu.Name = "BtnBuscarJu";
            BtnBuscarJu.Size = new System.Drawing.Size(186, 52);
            BtnBuscarJu.TabIndex = 3;
            BtnBuscarJu.UseVisualStyleBackColor = true;
            BtnVolverJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolverJu.BackgroundImage")));
            BtnVolverJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            BtnVolverJu.Location = new System.Drawing.Point(761, 457);
            BtnVolverJu.Name = "BtnVolverJu";
            BtnVolverJu.Size = new System.Drawing.Size(186, 52);
            BtnVolverJu.TabIndex = 4;
            BtnVolverJu.UseVisualStyleBackColor = true;
            BtnVolverJu.Click += new System.EventHandler(BtnVolverJu_Click);
            TxtApo.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TxtApo.Location = new System.Drawing.Point(391, 33);
            TxtApo.Name = "TxtApo";
            TxtApo.Size = new System.Drawing.Size(204, 45);
            TxtApo.TabIndex = 5;
            LblNombre.AutoSize = true;
            LblNombre.BackColor = System.Drawing.Color.Transparent;
            LblNombre.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblNombre.ForeColor = System.Drawing.Color.White;
            LblNombre.Location = new System.Drawing.Point(61, 99);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new System.Drawing.Size(235, 56);
            LblNombre.TabIndex = 6;
            LblNombre.Text = "NOMBRE";
            LblApodo.AutoSize = true;
            LblApodo.BackColor = System.Drawing.Color.Transparent;
            LblApodo.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LblApodo.ForeColor = System.Drawing.Color.White;
            LblApodo.Location = new System.Drawing.Point(381, 99);
            LblApodo.Name = "LblApodo";
            LblApodo.Size = new System.Drawing.Size(200, 56);
            LblApodo.TabIndex = 7;
            LblApodo.Text = "APODO";
            DgvJugadores.AllowUserToAddRows = false;
            DgvJugadores.AllowUserToDeleteRows = false;
            DgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            DgvJugadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColJugadorId,
            ColJugadorNombre,
            ColJugadorApodo,
            ColJugadorPuntos});
            DgvJugadores.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DgvJugadores.ForeColor = System.Drawing.Color.Black;
            DgvJugadores.Location = new System.Drawing.Point(71, 180);
            DgvJugadores.MultiSelect = false;
            DgvJugadores.Name = "DgvJugadores";
            DgvJugadores.ReadOnly = true;
            DgvJugadores.RowHeadersVisible = false;
            DgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvJugadores.Size = new System.Drawing.Size(600, 288);
            DgvJugadores.TabIndex = 8;
            ColJugadorId.HeaderText = "ID";
            ColJugadorId.Name = "ColJugadorId";
            ColJugadorId.ReadOnly = true;
            ColJugadorNombre.HeaderText = "Nombre";
            ColJugadorNombre.Name = "ColJugadorNombre";
            ColJugadorNombre.ReadOnly = true;
            ColJugadorApodo.HeaderText = "Apodo";
            ColJugadorApodo.Name = "ColJugadorApodo";
            ColJugadorApodo.ReadOnly = true;
            ColJugadorPuntos.HeaderText = "Puntos";
            ColJugadorPuntos.Name = "ColJugadorPuntos";
            ColJugadorPuntos.ReadOnly = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(DgvJugadores);
            Controls.Add(LblApodo);
            Controls.Add(LblNombre);
            Controls.Add(TxtApo);
            Controls.Add(BtnVolverJu);
            Controls.Add(BtnBuscarJu);
            Controls.Add(BtnEliminarJu);
            Controls.Add(BtnRegistrarJu);
            Controls.Add(TxtNom);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "JUGADORES";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "JUGADORES";
            Load += new System.EventHandler(JUGADORES_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Button BtnRegistrarJu;
        private System.Windows.Forms.Button BtnEliminarJu;
        private System.Windows.Forms.Button BtnBuscarJu;
        private System.Windows.Forms.Button BtnVolverJu;
        private System.Windows.Forms.TextBox TxtApo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblApodo;
        private System.Windows.Forms.DataGridView DgvJugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugadorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugadorNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugadorApodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJugadorPuntos;
    }
}


