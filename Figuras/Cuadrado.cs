using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Cuadrado: Rectangulo
    {
        #region "Atributos"
        private double _lado;
        #endregion

        #region "Consultas"
        public double getLado()
        { 
            return _lado;
        }

        public override double getArea()
        {
            return (_lado * _lado);
        }

        public override double getPerimetro()
        { 
            return (_lado * 4); 
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Cuadrado - Lado: " + _lado;

            return cadena;
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Cuadrado))
            {
                EsIgual = false;
            }
            else
            {
                Cuadrado Cuad = (Cuadrado)obj;
                EsIgual = (_lado == Cuad._lado);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(_lado) * 3000;
        }
        #endregion

        #region "Comandos"
        public void setLado(double y)
        {
            if (y > 0)
            {
                _lado = y;
            }
            else
            {
                _lado = 1;
            }
        }
        #endregion

        #region "Constructor"
        public Cuadrado()
        {
            _lado = 1;

        }
        public Cuadrado(double Lado)
        {
            if (Lado > 0)
            {
                _lado = Lado;
            }
            else
            {
                _lado = 1;
            }
        }
        #endregion
    }
}
