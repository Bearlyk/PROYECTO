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
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.BtnRegistrarJu = new System.Windows.Forms.Button();
            this.BtnEliminarJu = new System.Windows.Forms.Button();
            this.BtnBuscarJu = new System.Windows.Forms.Button();
            this.BtnVolverJu = new System.Windows.Forms.Button();
            this.TxtApo = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblApodo = new System.Windows.Forms.Label();
            this.DgvJugadores = new System.Windows.Forms.DataGridView();
            this.ColJugadorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJugadorNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJugadorApodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColJugadorPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(71, 33);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(204, 34);
            this.TxtNom.TabIndex = 0;
            // 
            // BtnRegistrarJu
            // 
            this.BtnRegistrarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarJu.BackgroundImage")));
            this.BtnRegistrarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistrarJu.Location = new System.Drawing.Point(707, 26);
            this.BtnRegistrarJu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRegistrarJu.Name = "BtnRegistrarJu";
            this.BtnRegistrarJu.Size = new System.Drawing.Size(187, 52);
            this.BtnRegistrarJu.TabIndex = 1;
            this.BtnRegistrarJu.UseVisualStyleBackColor = true;
            // 
            // BtnEliminarJu
            // 
            this.BtnEliminarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminarJu.BackgroundImage")));
            this.BtnEliminarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEliminarJu.Location = new System.Drawing.Point(728, 127);
            this.BtnEliminarJu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEliminarJu.Name = "BtnEliminarJu";
            this.BtnEliminarJu.Size = new System.Drawing.Size(187, 52);
            this.BtnEliminarJu.TabIndex = 2;
            this.BtnEliminarJu.UseVisualStyleBackColor = true;
            this.BtnEliminarJu.Click += new System.EventHandler(this.BtnEliminarJu_Click_1);
            // 
            // BtnBuscarJu
            // 
            this.BtnBuscarJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBuscarJu.BackgroundImage")));
            this.BtnBuscarJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBuscarJu.Location = new System.Drawing.Point(707, 250);
            this.BtnBuscarJu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnBuscarJu.Name = "BtnBuscarJu";
            this.BtnBuscarJu.Size = new System.Drawing.Size(187, 52);
            this.BtnBuscarJu.TabIndex = 3;
            this.BtnBuscarJu.UseVisualStyleBackColor = true;
            // 
            // BtnVolverJu
            // 
            this.BtnVolverJu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolverJu.BackgroundImage")));
            this.BtnVolverJu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolverJu.Location = new System.Drawing.Point(760, 444);
            this.BtnVolverJu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnVolverJu.Name = "BtnVolverJu";
            this.BtnVolverJu.Size = new System.Drawing.Size(187, 52);
            this.BtnVolverJu.TabIndex = 4;
            this.BtnVolverJu.UseVisualStyleBackColor = true;
            this.BtnVolverJu.Click += new System.EventHandler(this.BtnVolverJu_Click);
            // 
            // TxtApo
            // 
            this.TxtApo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApo.Location = new System.Drawing.Point(391, 33);
            this.TxtApo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtApo.Name = "TxtApo";
            this.TxtApo.Size = new System.Drawing.Size(204, 34);
            this.TxtApo.TabIndex = 5;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(61, 98);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(196, 46);
            this.LblNombre.TabIndex = 6;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblApodo
            // 
            this.LblApodo.AutoSize = true;
            this.LblApodo.BackColor = System.Drawing.Color.Transparent;
            this.LblApodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApodo.ForeColor = System.Drawing.Color.White;
            this.LblApodo.Location = new System.Drawing.Point(381, 98);
            this.LblApodo.Name = "LblApodo";
            this.LblApodo.Size = new System.Drawing.Size(165, 46);
            this.LblApodo.TabIndex = 7;
            this.LblApodo.Text = "APODO";
            // 
            // DgvJugadores
            // 
            this.DgvJugadores.AllowUserToAddRows = false;
            this.DgvJugadores.AllowUserToDeleteRows = false;
            this.DgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvJugadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColJugadorId,
            this.ColJugadorNombre,
            this.ColJugadorApodo,
            this.ColJugadorPuntos});
            this.DgvJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvJugadores.Location = new System.Drawing.Point(71, 180);
            this.DgvJugadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvJugadores.MultiSelect = false;
            this.DgvJugadores.Name = "DgvJugadores";
            this.DgvJugadores.ReadOnly = true;
            this.DgvJugadores.RowHeadersVisible = false;
            this.DgvJugadores.RowHeadersWidth = 51;
            this.DgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvJugadores.Size = new System.Drawing.Size(600, 288);
            this.DgvJugadores.TabIndex = 8;
            // 
            // ColJugadorId
            // 
            this.ColJugadorId.HeaderText = "ID";
            this.ColJugadorId.MinimumWidth = 6;
            this.ColJugadorId.Name = "ColJugadorId";
            this.ColJugadorId.ReadOnly = true;
            // 
            // ColJugadorNombre
            // 
            this.ColJugadorNombre.HeaderText = "Nombre";
            this.ColJugadorNombre.MinimumWidth = 6;
            this.ColJugadorNombre.Name = "ColJugadorNombre";
            this.ColJugadorNombre.ReadOnly = true;
            // 
            // ColJugadorApodo
            // 
            this.ColJugadorApodo.HeaderText = "Apodo";
            this.ColJugadorApodo.MinimumWidth = 6;
            this.ColJugadorApodo.Name = "ColJugadorApodo";
            this.ColJugadorApodo.ReadOnly = true;
            // 
            // ColJugadorPuntos
            // 
            this.ColJugadorPuntos.HeaderText = "Puntos";
            this.ColJugadorPuntos.MinimumWidth = 6;
            this.ColJugadorPuntos.Name = "ColJugadorPuntos";
            this.ColJugadorPuntos.ReadOnly = true;
            // 
            // JUGADORES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.DgvJugadores);
            this.Controls.Add(this.LblApodo);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtApo);
            this.Controls.Add(this.BtnVolverJu);
            this.Controls.Add(this.BtnBuscarJu);
            this.Controls.Add(this.BtnEliminarJu);
            this.Controls.Add(this.BtnRegistrarJu);
            this.Controls.Add(this.TxtNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JUGADORES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JUGADORES";
            this.Load += new System.EventHandler(this.JUGADORES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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


