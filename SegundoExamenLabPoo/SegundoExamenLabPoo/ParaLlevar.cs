using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundoExamenLabPoo
{
    public partial class ParaLlevar : Registro
    {
        public ParaLlevar()
        {
            InitializeComponent();
        }

        private void ParaLlevar_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Santa Elena");
            comboBox1.Items.Add("San Salvador");
            comboBox1.Items.Add("Santa Tecla");
            comboBox1.Items.Add("San Marcos");
            comboBox1.Items.Add("Metrocentro");
            comboBox1.Items.Add("Santa Ana");
            comboBox1.Items.Add("San Miguel");
        }
    }
}
