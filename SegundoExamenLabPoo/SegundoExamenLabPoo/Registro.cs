using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundoExamenLabPoo
{
    public partial class Registro : Base
    {
        double precio=0;
        double ham=5.60, pizza=7.00, taco=3.5, torta=5.10, papas=1.25, hotdog=2.00, soda=0.50, licuado=0.75;

        private void button4_Click(object sender, EventArgs e)
        {
            Menu volver = new Menu();
            volver.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "$0.00";
            precio = 0;
            for (int i = 0; i < menucomida.Items.Count; i++)
            {
                menucomida.SetItemChecked(i, false);
            }
            txtham.Text="0";
            txtpizza.Text="0";
            txttaco.Text="0";
            txttorta.Text="0";
            txtpapa.Text="0";
            txthotdog.Text="0";
            txtsoda.Text="0";
            txtlicuado.Text="0";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            int canham, canpizza, cantaco, cantorta, canpapas, canhtodog, cansoda, canlic;
            
            canham = Convert.ToInt32(txtham.Text);
            canpizza = Convert.ToInt32(txtpizza.Text);
            cantaco = Convert.ToInt32(txttaco.Text);
            cantorta = Convert.ToInt32(txttorta.Text);
            canpapas = Convert.ToInt32(txtpapa.Text);
            canhtodog = Convert.ToInt32(txthotdog.Text);
            cansoda = Convert.ToInt32(txtsoda.Text);
            canlic = Convert.ToInt32(txtlicuado.Text);

            precio = precio + ham * canham;
            precio = precio + pizza * canpizza;
            precio = precio + taco * cantaco;
            precio = precio + torta * cantorta;
            precio = precio + papas * canpapas;
            precio = precio + hotdog * canhtodog;
            precio = precio + soda * cansoda;
            precio = precio + licuado * canlic;
          
            label1.Text = Convert.ToString(Math.Round(precio,2));

        }

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            menucomida.Items.Add("Combo de hamburguesa......$5.60");
            menucomida.Items.Add("Pizza con soda......$7.00");
            menucomida.Items.Add("Orden de tacos......$3.50");
            menucomida.Items.Add("Torta con queso......$5.10");
            menucomida.Items.Add("Papas fritas......$1.25");
            menucomida.Items.Add("Hot Dog......$2.00");
            menucomida.Items.Add("Soda......$0.50");
            menucomida.Items.Add("Licuado......$0.75");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void menucomida_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menucomida.SelectedIndex == 0)
            {
                if (menucomida.GetItemChecked(0) == true)
                {
                    txtham.Text = "1";
                }
                else
                {
                    txtham.Text = "0";
                }

            }
            if (menucomida.SelectedIndex == 1)
            {
                if (menucomida.GetItemChecked(1) == true)
                {
                    txtpizza.Text = "1";
                }
                else
                {
                    txtpizza.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 2)
            {
                if (menucomida.GetItemChecked(2) == true)
                {
                    txttaco.Text = "1";
                }
                else
                {
                    txttaco.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 3)
            {
                if (menucomida.GetItemChecked(3) == true)
                {
                    txttorta.Text = "1";
                }
                else
                {
                    txttorta.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 4)
            {
                if (menucomida.GetItemChecked(4) == true)
                {
                    txtpapa.Text = "1";
                }
                else
                {
                    txtpapa.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 5)
            {
                if (menucomida.GetItemChecked(5) == true)
                {
                    txthotdog.Text = "1";
                }
                else
                {
                    txthotdog.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 6)
            {
                if (menucomida.GetItemChecked(6) == true)
                {
                    txtsoda.Text = "1";
                }
                else
                {
                    txtsoda.Text = "0";
                }
            }
            if (menucomida.SelectedIndex == 7)
            {
                if (menucomida.GetItemChecked(7) == true)
                {
                    txtlicuado.Text = "1";
                }
                else
                {
                    txtlicuado.Text = "0";
                }
            }



        }
    }
}
