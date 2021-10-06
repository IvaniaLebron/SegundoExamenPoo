using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundoExamenLabPoo
{
    public partial class Menu : Base
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Domicilio abrirdomilicio=new Domicilio();
            abrirdomilicio.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaLlevar abrirparallevar = new ParaLlevar();
            abrirparallevar.Show();
            this.Hide();
        }
    }
}
