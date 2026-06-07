namespace MENU_DE_TORNEOS_1._0
{
    partial class HISTORIAL
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
            LblBuscar = new System.Windows.Forms.Label();
            TxtBuscar = new System.Windows.Forms.TextBox();
            BtnBuscar = new System.Windows.Forms.Button();
            BtnMostrarTodo = new System.Windows.Forms.Button();
            BtnVolver = new System.Windows.Forms.Button();
            DgvHistorial = new System.Windows.Forms.DataGridView();
            ColHistorialFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialJugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialJugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialGanador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ColHistorialTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SuspendLayout();
            LblTitulo.BackColor = System.Drawing.Color.Transparent;
            LblTitulo.Font = new System.Drawing.Font("OCR A Extended", 22F, System.Drawing.FontStyle.Bold);
            LblTitulo.ForeColor = System.Drawing.Color.White;
            LblTitulo.Location = new System.Drawing.Point(60, 25);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new System.Drawing.Size(600, 40);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "HISTORIAL DE PARTIDAS";
            LblBuscar.BackColor = System.Drawing.Color.Transparent;
            LblBuscar.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold);
            LblBuscar.ForeColor = System.Drawing.Color.White;
            LblBuscar.Location = new System.Drawing.Point(60, 80);
            LblBuscar.Name = "LblBuscar";
            LblBuscar.Size = new System.Drawing.Size(360, 28);
            LblBuscar.TabIndex = 1;
            LblBuscar.Text = "BUSCAR JUGADOR O GANADOR";
            TxtBuscar.Font = new System.Drawing.Font("OCR A Extended", 11F, System.Drawing.FontStyle.Bold);
            TxtBuscar.Location = new System.Drawing.Point(60, 115);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new System.Drawing.Size(300, 29);
            TxtBuscar.TabIndex = 2;
            BtnBuscar.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnBuscar.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnBuscar.ForeColor = System.Drawing.Color.White;
            BtnBuscar.Location = new System.Drawing.Point(390, 112);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new System.Drawing.Size(130, 38);
            BtnBuscar.TabIndex = 3;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += new System.EventHandler(BtnBuscar_Click);
            BtnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnMostrarTodo.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnMostrarTodo.ForeColor = System.Drawing.Color.White;
            BtnMostrarTodo.Location = new System.Drawing.Point(540, 112);
            BtnMostrarTodo.Name = "BtnMostrarTodo";
            BtnMostrarTodo.Size = new System.Drawing.Size(130, 38);
            BtnMostrarTodo.TabIndex = 4;
            BtnMostrarTodo.Text = "TODO";
            BtnMostrarTodo.UseVisualStyleBackColor = false;
            BtnMostrarTodo.Click += new System.EventHandler(BtnMostrarTodo_Click);
            BtnVolver.BackColor = System.Drawing.Color.FromArgb(45, 45, 55);
            BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnVolver.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold);
            BtnVolver.ForeColor = System.Drawing.Color.White;
            BtnVolver.Location = new System.Drawing.Point(760, 475);
            BtnVolver.Name = "BtnVolver";
            BtnVolver.Size = new System.Drawing.Size(130, 38);
            BtnVolver.TabIndex = 5;
            BtnVolver.Text = "VOLVER";
            BtnVolver.UseVisualStyleBackColor = false;
            BtnVolver.Click += new System.EventHandler(BtnVolver_Click);
            DgvHistorial.AllowUserToAddRows = false;
            DgvHistorial.AllowUserToDeleteRows = false;
            DgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(20, 20, 20);
            DgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            ColHistorialFecha,
            ColHistorialId,
            ColHistorialJugador1,
            ColHistorialP1,
            ColHistorialP2,
            ColHistorialJugador2,
            ColHistorialGanador,
            ColHistorialTipo});
            DgvHistorial.Font = new System.Drawing.Font("OCR A Extended", 9F, System.Drawing.FontStyle.Bold);
            DgvHistorial.ForeColor = System.Drawing.Color.Black;
            DgvHistorial.Location = new System.Drawing.Point(60, 170);
            DgvHistorial.MultiSelect = false;
            DgvHistorial.Name = "DgvHistorial";
            DgvHistorial.ReadOnly = true;
            DgvHistorial.RowHeadersVisible = false;
            DgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DgvHistorial.Size = new System.Drawing.Size(830, 284);
            DgvHistorial.TabIndex = 6;
            ColHistorialFecha.HeaderText = "Fecha";
            ColHistorialFecha.Name = "ColHistorialFecha";
            ColHistorialFecha.ReadOnly = true;
            ColHistorialId.HeaderText = "ID";
            ColHistorialId.Name = "ColHistorialId";
            ColHistorialId.ReadOnly = true;
            ColHistorialJugador1.HeaderText = "Jugador 1";
            ColHistorialJugador1.Name = "ColHistorialJugador1";
            ColHistorialJugador1.ReadOnly = true;
            ColHistorialP1.HeaderText = "P1";
            ColHistorialP1.Name = "ColHistorialP1";
            ColHistorialP1.ReadOnly = true;
            ColHistorialP2.HeaderText = "P2";
            ColHistorialP2.Name = "ColHistorialP2";
            ColHistorialP2.ReadOnly = true;
            ColHistorialJugador2.HeaderText = "Jugador 2";
            ColHistorialJugador2.Name = "ColHistorialJugador2";
            ColHistorialJugador2.ReadOnly = true;
            ColHistorialGanador.HeaderText = "Ganador";
            ColHistorialGanador.Name = "ColHistorialGanador";
            ColHistorialGanador.ReadOnly = true;
            ColHistorialTipo.HeaderText = "Tipo";
            ColHistorialTipo.Name = "ColHistorialTipo";
            ColHistorialTipo.ReadOnly = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(15, 15, 18);
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(DgvHistorial);
            Controls.Add(BtnVolver);
            Controls.Add(BtnMostrarTodo);
            Controls.Add(BtnBuscar);
            Controls.Add(TxtBuscar);
            Controls.Add(LblBuscar);
            Controls.Add(LblTitulo);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "HISTORIAL";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HISTORIAL";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnMostrarTodo;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.DataGridView DgvHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialJugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialJugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialGanador;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHistorialTipo;
    }
}

