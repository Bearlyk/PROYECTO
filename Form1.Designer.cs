namespace MENU_DE_TORNEOS_1._0
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bt_Inicio = new System.Windows.Forms.Button();
            SuspendLayout();
            Bt_Inicio.BackColor = System.Drawing.SystemColors.ControlText;
            Bt_Inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_Inicio.BackgroundImage")));
            Bt_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            Bt_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Bt_Inicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            Bt_Inicio.Location = new System.Drawing.Point(297, 139);
            Bt_Inicio.Name = "Bt_Inicio";
            Bt_Inicio.Size = new System.Drawing.Size(389, 249);
            Bt_Inicio.TabIndex = 0;
            Bt_Inicio.UseVisualStyleBackColor = false;
            Bt_Inicio.Click += new System.EventHandler(Bt_Inicio_Click);
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(976, 546);
            Controls.Add(Bt_Inicio);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "INICIO";
            Load += new System.EventHandler(Form1_Load);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_Inicio;
    }
}



