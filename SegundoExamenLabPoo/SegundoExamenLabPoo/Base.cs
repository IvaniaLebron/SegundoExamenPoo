using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoExamenLabPoo
{
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //activa el boton salir para confirmar que se quiere salir de la app
            if (MessageBox.Show("¿Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Base_Load(object sender, EventArgs e)
        {

        }
    }
}
