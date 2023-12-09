using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Circulo: Figura
    {
        #region "Atributos"
        private double Radio;
        #endregion

        #region "Consultas"
        public double getRadio()
        {
            return Radio; 
        }

        public override double getArea()
        { 
            return Math.PI * (Radio * Radio);
        }

        public override double getPerimetro()
        { 
            return Math.PI * (Radio * 2); 
        }

        public override string ToString()
        {
            string cadena = "Circulo - Radio: " + Radio;

            return cadena;
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Circulo))
            {
                EsIgual = false;
            }
            else
            {
                Circulo Cir = (Circulo) obj;
                EsIgual = (Radio == Cir.Radio);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(Radio) * 2500;
        }
        #endregion

        #region "Comandos"
        public void setRadio(double y)
        {
            if (y > 0)
            {
                Radio = y;
            }
            else
            {
                Radio = 1;
            }
        }
        #endregion

        #region "Constructor"
        public Circulo()
        {
            Radio = 1;
        }

        public Circulo(double x)
        {
            if (x > 0)
            {
                Radio = x;
            }
            else
            {
                Radio = 1;
            }
        }
        #endregion
    }
}
