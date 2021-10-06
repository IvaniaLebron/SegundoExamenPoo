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
            //agrega elementos al combobox
            Items();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Recibo();
            Limpiar();
        }
        private void Limpiar()
        {
            //devuelve todo a su valor inicial
            label1.Text = "$0.00";
            for (int i = 0; i < menucomida.Items.Count; i++)
            {
                menucomida.SetItemChecked(i, false);
            }
            txtham.Text = "0";
            txtpizza.Text = "0";
            txttaco.Text = "0";
            txttorta.Text = "0";
            txtpapa.Text = "0";
            txthotdog.Text = "0";
            txtsoda.Text = "0";
            txtlicuado.Text = "0";
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void Recibo()
        {
            //condiciona si hay algun campo de dato vacio para advertir que hacen falta datos
            if (textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Dejaste campos vacíos, por favor completa los datos");
            }
            //condiciona si no hay nada de comida seleccionada para advertirlo
            else if

                (menucomida.GetItemChecked(0) == false & menucomida.GetItemChecked(1) == false &
                    menucomida.GetItemChecked(2) == false & menucomida.GetItemChecked(3) == false &
                    menucomida.GetItemChecked(4) == false & menucomida.GetItemChecked(5) == false &
                    menucomida.GetItemChecked(6) == false & menucomida.GetItemChecked(7) == false)
            {
                MessageBox.Show("No has ordenado nada, intenta con una pizza :D");
            }
            //si todo esta en orden, procede a generar el recibo
            else
            {
                string nombre, correo, numero, sucursal;
                nombre = textBox3.Text;
                correo = textBox4.Text;
                numero = textBox5.Text;
                sucursal = comboBox1.Text;
                int[] cantidad = new int[8];
                cantidad[0] = Convert.ToInt32(txtham.Text);
                cantidad[1] = Convert.ToInt32(txtpizza.Text);
                cantidad[2] = Convert.ToInt32(txttaco.Text);
                cantidad[3] = Convert.ToInt32(txttorta.Text);
                cantidad[4] = Convert.ToInt32(txtpapa.Text);
                cantidad[5] = Convert.ToInt32(txthotdog.Text);
                cantidad[6] = Convert.ToInt32(txtsoda.Text);
                cantidad[7] = Convert.ToInt32(txtlicuado.Text);
                string cadena = ""; //cadena vacia para ir guardando lo que el cliente pidio
                //cada if verifica si el cliente pidio algo y cuanto se le cobrara
                if (menucomida.GetItemChecked(0) == true)
                {
                    cadena = cadena + $"{cantidad[0]}\tCombo de hamburguesa\t$5.60 c/u\t${cantidad[0] * 5.60}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(1) == true)
                {
                    cadena = cadena + $"{cantidad[1]}\tPizza con soda\t$7.00 c/u\t${cantidad[1] * 7.00}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(2) == true)
                {
                    cadena = cadena + $"{cantidad[2]}\tOrden de tacos\t$3.50 c/u\t${cantidad[2] * 3.5}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(3) == true)
                {
                    cadena = cadena + $"{cantidad[3]}\tTorta con queso\t$5.10 c/u\t${cantidad[3] * 5.10}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(4) == true)
                {
                    cadena = cadena + $"{cantidad[4]}\tPapas fritas\t$1.25 c/u\t${cantidad[4] * 1.25}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(5) == true)
                {
                    cadena = cadena + $"{cantidad[5]}\tHot Dog\t$2.00 c/u\t${cantidad[5] * 2.00}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(6) == true)
                {
                    cadena = cadena + $"{cantidad[6]}\tSoda\t$0.50 c/u\t${cantidad[6] * 0.50}\n";
                }
                else { cadena = cadena + ""; }
                if (menucomida.GetItemChecked(7) == true)
                {
                    cadena = cadena + $"{cantidad[7]}\tLicuado\t$0.75 c/u\t${cantidad[7] * 0.75}\n";
                }
                else { cadena = cadena + ""; }
                //muestra el recibo ya hecho
                MessageBox.Show(
                    $"\t\t\tOrden para llevar\t\t\t\n" +
                    $"Cliente: {nombre}\n Correo: {correo} || Número: {numero}\n" +
                    $"{cadena}" + $"\t\t\t\t\t\t\t\t\t\tTotal a pagar:${label1.Text}\n" +
                    $"\nGracias por comprar con nosotros, tu comida estará lista en la sucursal de {sucursal}", "Recibo");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Items()
        {
            //agrega las sucursales al combobox
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
