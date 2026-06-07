using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU_DE_TORNEOS_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bt_Inicio.BackColor=Color.Transparent;
            Bt_Inicio.FlatStyle=FlatStyle.Flat;
            Bt_Inicio.FlatAppearance.BorderSize = 0;  
        }

        private void Bt_Inicio_Click(object sender, EventArgs e)
        {
            MENU menu= new MENU();
            menu.Show();
            Hide();
        }
    }
}

