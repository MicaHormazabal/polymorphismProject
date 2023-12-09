using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Triangulo: Figura
    {
        #region "Atributos"
        private double _base;
        private double _altura;
        private double _lado1;
        private double _lado2;
        #endregion

        #region "Estaticos"
        public static bool TriValido(double b, double h, double l1, double l2)
        {
            bool esValido = (b >= 0 && h >= 0 && l1 >= 0 && l2 >= 0);
            return esValido;
        }
        #endregion

        #region "Consultas"
        public double getBase()
        { 
            return _base;
        }

        public double getAltura()
        { 
            return _altura; 
        }

        public double getLado1()
        { 
            return _lado1; 
        }

        public double getLado2()
        { 
            return _lado2; 
        }

        public override double getArea()
        { 
            return (_base * _altura) / 2; 
        }

        public override double getPerimetro()
        { 
            return (_base + _lado1 + _lado2); 
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Triangulo - Base: " + _base;
            cadena += " - Altura: " + _altura;
            cadena += " - Lado1: " + _lado1;
            cadena += " - Lado2: " + _lado2;

            return cadena;
        }
        #endregion

        #region "Comandos"
        public void setBase(double y)
        {
            if (y > 0)
            {
                _base = y;
            }
            else
            {
                _base = 1;
            }
        }
        public void setAltura(double y)
        {
            if (y > 0)
            {
                _altura = y;
            }
            else
            {
                _altura = 1;
            }
        }
        public void setLado1(double y)
        {
            if (y > 0)
            {
                _lado1 = y;
            }
            else
            {
                _lado2 = 1;
            }
        }
        public void setLado2(double y)
        {
            if (y > 0)
            {
                _lado2 = y;
            }
            else
            {
                _lado2 = 1;
            }
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Triangulo))
            {
                EsIgual = false;
            }
            else
            {
                Triangulo Tri = (Triangulo)obj;
                EsIgual = (_altura == Tri._altura) && (_base == Tri._base) && (_lado1 == Tri._lado1) && (_lado2 == Tri._lado2);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(_base + _lado1 * _lado2) * 3100;
        }
        #endregion

        #region "Constructor"
        public Triangulo()
        {
            _base = 1;
            _altura = 1;
            _lado1 = 1;
            _lado2 = 1;

        }
        public Triangulo(double Base, double Alt, double L1, double L2)
        {
            if ((Base > 0) && (Alt > 0) && (L1 > 0) && (L2 > 0))
            {
                _base = Base;
                _altura = Alt;
                _lado1 = L1;
                _lado2 = L2;
            }
            else
            {
                _base = 1;
                _altura = 1;
                _lado1 = 1;
                _lado2 = 1;
            }
        }
        #endregion
    }
}
