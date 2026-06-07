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
            LblJugador1 = new System.Windows.Forms.Label();
            LblJugador2 = new System.Windows.Forms.Label();
            LblP1 = new System.Windows.Forms.Label();
            LblP2 = new System.Windows.Forms.Label();
            LblTipo = new System.Windows.Forms.Label();
            CmbJugador1 = new System.Windows.Forms.ComboBox();
            CmbJugador2 = new System.Windows.Forms.ComboBox();
            TxtPuntos1 = new System.Windows.Forms.TextBox();
            TxtPuntos2 = new System.Windows.Forms.TextBox();
            CmbTipoTorneo = new System.Windows.Forms.ComboBox();
            BtnRegistrar = new System.Windows.Forms.Button();
            BtnLimpiar = new System.Windows.Forms.Button();
            BtnVolver = new System.Windows.Forms.Button();
            DgvPartidas = new System.Windows.Forms.DataGridView();
            ColPartidaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColPartidaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SuspendLayout();
            LblJugador1.BackColor = System.Drawing.Color.Transparent;
            LblJugador1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            LblJugador1.ForeColor = System.Drawing.Color.White;
            LblJugador1.Location = new System.Drawing.Point(60, 35);
            LblJugador1.Name = "LblJugador1";
            LblJugador1.Size = new System.Drawing.Size(260, 30);
            LblJugador1.TabIndex = 0;
            LblJugador1.Text = "JUGADOR 1";
            LblJugador2.BackColor = System.Drawing.Color.Transparent;
            LblJugador2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            LblJugador2.ForeColor = System.Drawing.Color.White;
            LblJugador2.Location = new System.Drawing.Point(350, 35);
            LblJugador2.Name = "LblJugador2";
            LblJugador2.Size = new System.Drawing.Size(260, 30);
            LblJugador2.TabIndex = 1;
            LblJugador2.Text = "JUGADOR 2";
            LblP1.BackColor = System.Drawing.Color.Transparent;
            LblP1.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            LblP1.ForeColor = System.Drawing.Color.White;
            LblP1.Location = new System.Drawing.Point(640, 35);
            LblP1.Name = "LblP1";
            LblP1.Size = new System.Drawing.Size(70, 30);
            LblP1.TabIndex = 2;
            LblP1.Text = "P1";
            LblP2.BackColor = System.Drawing.Color.Transparent;
            LblP2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            LblP2.ForeColor = System.Drawing.Color.White;
            LblP2.Location = new System.Drawing.Point(740, 35);
            LblP2.Name = "LblP2";
            LblP2.Size = new System.Drawing.Size(70, 30);
            LblP2.TabIndex = 3;
            LblP2.Text = "P2";
            LblTipo.BackColor = System.Drawing.Color.Transparent;
            LblTipo.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold);
            LblTipo.ForeColor = System.Drawing.Color.White;
            LblTipo.Location = new System.Drawing.Point(60, 115);
            LblTipo.Name = "LblTipo";
            LblTipo.Size = new System.Drawing.Size(260, 30);
            LblTipo.TabIndex = 4;
            LblTipo.Text = "TIPO";
            CmbJugador1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbJugador1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            CmbJugador1.FormattingEnabled = true;
            CmbJugador1.Location = new System.Drawing.Point(60, 75);
            CmbJugador1.Name = "CmbJugador1";
            CmbJugador1.Size = new System.Drawing.Size(250, 28);
            CmbJugador1.TabIndex = 5;
            CmbJugador2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbJugador2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            CmbJugador2.FormattingEnabled = true;
            CmbJugador2.Location = new System.Drawing.Point(350, 75);
            CmbJugador2.Name = "CmbJugador2";
            CmbJugador2.Size = new System.Drawing.Size(250, 28);
            CmbJugador2.TabIndex = 6;
            TxtPuntos1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            TxtPuntos1.Location = new System.Drawing.Point(640, 75);
            TxtPuntos1.Name = "TxtPuntos1";
            TxtPuntos1.Size = new System.Drawing.Size(70, 31);
            TxtPuntos1.TabIndex = 7;
            TxtPuntos2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            TxtPuntos2.Location = new System.Drawing.Point(740, 75);
            TxtPuntos2.Name = "TxtPuntos2";
            TxtPuntos2.Size = new System.Drawing.Size(70, 31);
            TxtPuntos2.TabIndex = 8;
            CmbTipoTorneo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            CmbTipoTorneo.Enabled = false;
            CmbTipoTorneo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            CmbTipoTorneo.FormattingEnabled = true;
            CmbTipoTorneo.Location = new System.Drawing.Point(60, 155);
            CmbTipoTorneo.Name = "CmbTipoTorneo";
            CmbTipoTorneo.Size = new System.Drawing.Size(250, 28);
            CmbTipoTorneo.TabIndex = 9;
            BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnRegistrar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnRegistrar.ForeColor = System.Drawing.Color.White;
            BtnRegistrar.Location = new System.Drawing.Point(820, 72);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new System.Drawing.Size(130, 38);
            BtnRegistrar.TabIndex = 10;
            BtnRegistrar.Text = "REGISTRAR";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += new System.EventHandler(BtnRegistrar_Click);
            BtnLimpiar.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnLimpiar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnLimpiar.ForeColor = System.Drawing.Color.White;
            BtnLimpiar.Location = new System.Drawing.Point(820, 150);
            BtnLimpiar.Name = "BtnLimpiar";
            BtnLimpiar.Size = new System.Drawing.Size(130, 38);
            BtnLimpiar.TabIndex = 11;
            BtnLimpiar.Text = "LIMPIAR";
            BtnLimpiar.UseVisualStyleBackColor = false;
            BtnLimpiar.Click += new System.EventHandler(BtnLimpiar_Click);
            BtnVolver.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnVolver.ForeColor = System.Drawing.Color.White;
            BtnVolver.Location = new System.Drawing.Point(820, 475);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new System.Drawing.Size(130, 38);
            BtnVolver.TabIndex = 12;
            BtnVolver.Text = "VOLVER";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += new System.EventHandler(BtnVolver_Click);
            DgvPartidas.AllowUserToAddRows = false;
            DgvPartidas.AllowUserToDeleteRows = false;
            DgvPartidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvPartidas.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            DgvPartidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPartidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColPartidaId,
            ColPartidaJugador1,
            ColPartidaP1,
            ColPartidaP2,
            ColPartidaJugador2,
            ColPartidaGanador,
            ColPartidaTipo});
            DgvPartidas.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            DgvPartidas.ForeColor = System.Drawing.Color.Black;
            DgvPartidas.Location = new System.Drawing.Point(60, 220);
            DgvPartidas.MultiSelect = false;
            DgvPartidas.Name = "DgvPartidas";
            DgvPartidas.ReadOnly = true;
            DgvPartidas.RowHeadersVisible = false;
            DgvPartidas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvPartidas.Size = new System.Drawing.Size(750, 284);
            DgvPartidas.TabIndex = 13;
            ColPartidaId.HeaderText = "ID";
            ColPartidaId.Name = "ColPartidaId";
            ColPartidaId.ReadOnly = true;
            ColPartidaJugador1.HeaderText = "Jugador 1";
            ColPartidaJugador1.Name = "ColPartidaJugador1";
            ColPartidaJugador1.ReadOnly = true;
            ColPartidaP1.HeaderText = "P1";
            ColPartidaP1.Name = "ColPartidaP1";
            ColPartidaP1.ReadOnly = true;
            ColPartidaP2.HeaderText = "P2";
            ColPartidaP2.Name = "ColPartidaP2";
            ColPartidaP2.ReadOnly = true;
            ColPartidaJugador2.HeaderText = "Jugador 2";
            ColPartidaJugador2.Name = "ColPartidaJugador2";
            ColPartidaJugador2.ReadOnly = true;
            ColPartidaGanador.HeaderText = "Ganador";
            ColPartidaGanador.Name = "ColPartidaGanador";
            ColPartidaGanador.ReadOnly = true;
            ColPartidaTipo.HeaderText = "Tipo";
            ColPartidaTipo.Name = "ColPartidaTipo";
            ColPartidaTipo.ReadOnly = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 18);
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(DgvPartidas);
            Controls.Add(BtnVolver);
            Controls.Add(BtnLimpiar);
            Controls.Add(BtnRegistrar);
            Controls.Add(CmbTipoTorneo);
            Controls.Add(TxtPuntos2);
            Controls.Add(TxtPuntos1);
            Controls.Add(CmbJugador2);
            Controls.Add(CmbJugador1);
            Controls.Add(LblTipo);
            Controls.Add(LblP2);
            Controls.Add(LblP1);
            Controls.Add(LblJugador2);
            Controls.Add(LblJugador1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "PARTIDAS";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PARTIDAS";
            ResumeLayout(false);
            PerformLayout();
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

