using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoExamenLabPoo
{
    class Recibo
    {
        double ham, pizza, taco, torta, papas,hotdog, soda, licuado;
        private double Hamburguesa
        {
            get { return ham; }
            set { ham = value; }
        }
        private double Pizza
        {
            get { return pizza; }
            set { pizza = value; }
        }
        private double Taco
        {
            get { return taco; }
            set { taco = value; }
        }
        private double Torta
        {
            get { return torta; }
            set { torta= value; }
        }
        private double Papas
        {
            get { return papas; }
            set { papas = value; }
        }
        private double Hotdog
        {
            get { return hotdog; }
            set { hotdog = value; }
        }
        private double Soda
        {
            get { return soda; }
            set { soda = value; }
        }
        private double Licuado
        {
            get { return licuado; }
            set { licuado = value; }
        }
        public double Ham(double pham)
        {
            ham = pham;
            return 5.60;
        }
        public double PizzaPizza(double ppizza)
        {
            pizza=ppizza;
            return 7.00;
        }
    }
}
