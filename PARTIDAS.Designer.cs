namespace MENU_DE_TORNEOS_1._0
{
    partial class PARTIDAS
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
            this.LblJugador1 = new System.Windows.Forms.Label();
            this.LblJugador2 = new System.Windows.Forms.Label();
            this.LblP1 = new System.Windows.Forms.Label();
            this.LblP2 = new System.Windows.Forms.Label();
            this.LblTipo = new System.Windows.Forms.Label();
            this.CmbJugador1 = new System.Windows.Forms.ComboBox();
            this.CmbJugador2 = new System.Windows.Forms.ComboBox();
            this.TxtPuntos1 = new System.Windows.Forms.TextBox();
            this.TxtPuntos2 = new System.Windows.Forms.TextBox();
            this.CmbTipoTorneo = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.DgvPartidas = new System.Windows.Forms.DataGridView();
            this.ColPartidaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPartidaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidas)).BeginInit();
            this.SuspendLayout();
            // 
            // LblJugador1
            // 
            this.LblJugador1.BackColor = System.Drawing.Color.Transparent;
            this.LblJugador1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            this.LblJugador1.ForeColor = System.Drawing.Color.White;
            this.LblJugador1.Location = new System.Drawing.Point(60, 35);
            this.LblJugador1.Name = "LblJugador1";
            this.LblJugador1.Size = new System.Drawing.Size(260, 30);
            this.LblJugador1.TabIndex = 0;
            this.LblJugador1.Text = "JUGADOR 1";
            // 
            // LblJugador2
            // 
            this.LblJugador2.BackColor = System.Drawing.Color.Transparent;
            this.LblJugador2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            this.LblJugador2.ForeColor = System.Drawing.Color.White;
            this.LblJugador2.Location = new System.Drawing.Point(350, 35);
            this.LblJugador2.Name = "LblJugador2";
            this.LblJugador2.Size = new System.Drawing.Size(260, 30);
            this.LblJugador2.TabIndex = 1;
            this.LblJugador2.Text = "JUGADOR 2";
            // 
            // LblP1
            // 
            this.LblP1.BackColor = System.Drawing.Color.Transparent;
            this.LblP1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            this.LblP1.ForeColor = System.Drawing.Color.White;
            this.LblP1.Location = new System.Drawing.Point(640, 35);
            this.LblP1.Name = "LblP1";
            this.LblP1.Size = new System.Drawing.Size(70, 30);
            this.LblP1.TabIndex = 2;
            this.LblP1.Text = "P1";
            // 
            // LblP2
            // 
            this.LblP2.BackColor = System.Drawing.Color.Transparent;
            this.LblP2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            this.LblP2.ForeColor = System.Drawing.Color.White;
            this.LblP2.Location = new System.Drawing.Point(740, 35);
            this.LblP2.Name = "LblP2";
            this.LblP2.Size = new System.Drawing.Size(70, 30);
            this.LblP2.TabIndex = 3;
            this.LblP2.Text = "P2";
            // 
            // LblTipo
            // 
            this.LblTipo.BackColor = System.Drawing.Color.Transparent;
            this.LblTipo.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            this.LblTipo.ForeColor = System.Drawing.Color.White;
            this.LblTipo.Location = new System.Drawing.Point(60, 115);
            this.LblTipo.Name = "LblTipo";
            this.LblTipo.Size = new System.Drawing.Size(250, 30);
            this.LblTipo.TabIndex = 4;
            this.LblTipo.Text = "TIPO";
            // 
            // CmbJugador1
            // 
            this.CmbJugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJugador1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.CmbJugador1.FormattingEnabled = true;
            this.CmbJugador1.Location = new System.Drawing.Point(60, 75);
            this.CmbJugador1.Name = "CmbJugador1";
            this.CmbJugador1.Size = new System.Drawing.Size(250, 26);
            this.CmbJugador1.TabIndex = 5;
            // 
            // CmbJugador2
            // 
            this.CmbJugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbJugador2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.CmbJugador2.FormattingEnabled = true;
            this.CmbJugador2.Location = new System.Drawing.Point(350, 75);
            this.CmbJugador2.Name = "CmbJugador2";
            this.CmbJugador2.Size = new System.Drawing.Size(250, 26);
            this.CmbJugador2.TabIndex = 6;
            // 
            // TxtPuntos1
            // 
            this.TxtPuntos1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.TxtPuntos1.Location = new System.Drawing.Point(640, 75);
            this.TxtPuntos1.Name = "TxtPuntos1";
            this.TxtPuntos1.Size = new System.Drawing.Size(70, 28);
            this.TxtPuntos1.TabIndex = 7;
            // 
            // TxtPuntos2
            // 
            this.TxtPuntos2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            this.TxtPuntos2.Location = new System.Drawing.Point(740, 75);
            this.TxtPuntos2.Name = "TxtPuntos2";
            this.TxtPuntos2.Size = new System.Drawing.Size(70, 28);
            this.TxtPuntos2.TabIndex = 8;
            // 
            // CmbTipoTorneo
            // 
            this.CmbTipoTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoTorneo.Enabled = false;
            this.CmbTipoTorneo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.CmbTipoTorneo.FormattingEnabled = true;
            this.CmbTipoTorneo.Location = new System.Drawing.Point(60, 155);
            this.CmbTipoTorneo.Name = "CmbTipoTorneo";
            this.CmbTipoTorneo.Size = new System.Drawing.Size(250, 26);
            this.CmbTipoTorneo.TabIndex = 9;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(820, 72);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(130, 38);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "REGISTRAR";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLimpiar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpiar.Location = new System.Drawing.Point(820, 150);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(130, 38);
            this.BtnLimpiar.TabIndex = 11;
            this.BtnLimpiar.Text = "LIMPIAR";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            this.BtnVolver.ForeColor = System.Drawing.Color.White;
            this.BtnVolver.Location = new System.Drawing.Point(820, 475);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(130, 38);
            this.BtnVolver.TabIndex = 12;
            this.BtnVolver.Text = "VOLVER";
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // DgvPartidas
            // 
            this.DgvPartidas.AllowUserToAddRows = false;
            this.DgvPartidas.AllowUserToDeleteRows = false;
            this.DgvPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPartidas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPartidaId,
            this.ColPartidaJugador1,
            this.ColPartidaP1,
            this.ColPartidaP2,
            this.ColPartidaJugador2,
            this.ColPartidaGanador,
            this.ColPartidaTipo});
            this.DgvPartidas.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            this.DgvPartidas.Location = new System.Drawing.Point(60, 220);
            this.DgvPartidas.MultiSelect = false;
            this.DgvPartidas.Name = "DgvPartidas";
            this.DgvPartidas.ReadOnly = true;
            this.DgvPartidas.RowHeadersVisible = false;
            this.DgvPartidas.RowHeadersWidth = 51;
            this.DgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPartidas.Size = new System.Drawing.Size(750, 284);
            this.DgvPartidas.TabIndex = 13;
            // 
            // ColPartidaId
            // 
            this.ColPartidaId.HeaderText = "ID";
            this.ColPartidaId.MinimumWidth = 6;
            this.ColPartidaId.Name = "ColPartidaId";
            this.ColPartidaId.ReadOnly = true;
            // 
            // ColPartidaJugador1
            // 
            this.ColPartidaJugador1.HeaderText = "Jugador 1";
            this.ColPartidaJugador1.MinimumWidth = 6;
            this.ColPartidaJugador1.Name = "ColPartidaJugador1";
            this.ColPartidaJugador1.ReadOnly = true;
            // 
            // ColPartidaP1
            // 
            this.ColPartidaP1.HeaderText = "P1";
            this.ColPartidaP1.MinimumWidth = 6;
            this.ColPartidaP1.Name = "ColPartidaP1";
            this.ColPartidaP1.ReadOnly = true;
            // 
            // ColPartidaP2
            // 
            this.ColPartidaP2.HeaderText = "P2";
            this.ColPartidaP2.MinimumWidth = 6;
            this.ColPartidaP2.Name = "ColPartidaP2";
            this.ColPartidaP2.ReadOnly = true;
            // 
            // ColPartidaJugador2
            // 
            this.ColPartidaJugador2.HeaderText = "Jugador 2";
            this.ColPartidaJugador2.MinimumWidth = 6;
            this.ColPartidaJugador2.Name = "ColPartidaJugador2";
            this.ColPartidaJugador2.ReadOnly = true;
            // 
            // ColPartidaGanador
            // 
            this.ColPartidaGanador.HeaderText = "Ganador";
            this.ColPartidaGanador.MinimumWidth = 6;
            this.ColPartidaGanador.Name = "ColPartidaGanador";
            this.ColPartidaGanador.ReadOnly = true;
            // 
            // ColPartidaTipo
            // 
            this.ColPartidaTipo.HeaderText = "Tipo";
            this.ColPartidaTipo.MinimumWidth = 6;
            this.ColPartidaTipo.Name = "ColPartidaTipo";
            this.ColPartidaTipo.ReadOnly = true;
            // 
            // PARTIDAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(976, 546);
            this.Controls.Add(this.DgvPartidas);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CmbTipoTorneo);
            this.Controls.Add(this.TxtPuntos2);
            this.Controls.Add(this.TxtPuntos1);
            this.Controls.Add(this.CmbJugador2);
            this.Controls.Add(this.CmbJugador1);
            this.Controls.Add(this.LblTipo);
            this.Controls.Add(this.LblP2);
            this.Controls.Add(this.LblP1);
            this.Controls.Add(this.LblJugador2);
            this.Controls.Add(this.LblJugador1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PARTIDAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARTIDAS";
            ((System.ComponentModel.ISupportInitialize)(this.DgvPartidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblJugador1;
        private System.Windows.Forms.Label LblJugador2;
        private System.Windows.Forms.Label LblP1;
        private System.Windows.Forms.Label LblP2;
        private System.Windows.Forms.Label LblTipo;
        private System.Windows.Forms.ComboBox CmbJugador1;
        private System.Windows.Forms.ComboBox CmbJugador2;
        private System.Windows.Forms.TextBox TxtPuntos1;
        private System.Windows.Forms.TextBox TxtPuntos2;
        private System.Windows.Forms.ComboBox CmbTipoTorneo;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView DgvPartidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaJugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaJugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaGanador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPartidaTipo;
    }
}

