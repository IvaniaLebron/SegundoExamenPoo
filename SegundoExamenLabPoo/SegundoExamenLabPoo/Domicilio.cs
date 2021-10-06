using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SegundoExamenLabPoo
{
    public partial class Domicilio : Registro
    {
        public Domicilio()
        {
            InitializeComponent();
        }

        private void Domicilio_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Tarjeta");
            comboBox1.Items.Add("Efectivo");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombre, correo, numero,direccion,pago;
            nombre = textBox3.Text;
            correo = textBox4.Text;
            numero = textBox5.Text;
            direccion = textBox6.Text;
            pago = comboBox1.Text;
            int[] cantidad=new int[7];
           /* MessageBox.Show($"Nombre completo: {persona.Nombre} {persona.Apellido}" +
                    $"\n Dirección: {persona.Direccion} | Telefono: {persona.Telefono}" +
                    $"\n\n- {cantSopa} Sopa(s)    x    ${sopaPrecio}/u    =    ${totalSopa}" +
                    $"\n\n- {cantPizza} Pizza(s)    x    ${pizzaPrecio}/u    =    ${totalPizza}" +
                    $"\n\n- {cantLasagna} Lasagna(s)    x    ${lasagnaPrecio}/u    =    ${totalLasagna}" +
                    $"\n\n- {cantCarne} Carne(s)    x    ${carnePrecio}/u    =    ${totalCarne}" +
                    $"\n\n- {cantHamburguesa} Hamburguesa(s)    x    ${hamburguesaPrecio}/u    =    ${totalHamburguesa}" +
                    $"\n\n- Total a pagar:    ${Math.Round(precioFinal, 2)} (INCLUIDO DOMICILIO)", "Total compra", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
          /* MessageBox.Show(
               $"\t\t\tOrden a domicilio\t\t\t\n"+
               $"Cliente: {nombre}\n Correo: {correo} || Número: {numero}\n"+
               $""
               )*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double cargo, precio;
            precio =Convert.ToDouble( label1.Text);
            cargo = precio + 3.00;
            label1.Text = $"${cargo}";

        }
    }
}
