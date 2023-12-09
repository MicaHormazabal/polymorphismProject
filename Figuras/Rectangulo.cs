using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuras
{
    internal class Rectangulo: Figura
    {
        #region "Atributos"
        private double _base;
        private double _altura;
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

        public override double getArea()
        {
            return (_base * _altura); 
        }

        public override double getPerimetro()
        { 
            return (_base * 2 + _altura * 2); 
        }

        public override string ToString()
        {
            string cadena;
            cadena = "Rectangulo - Base: " + _base;
            cadena += " - Altura: " + _altura;

            return cadena;
        }

        public override bool Equals(object obj)
        {
            bool EsIgual;

            if (obj == null)
            {
                EsIgual = (this == null);
            }
            else if (obj.GetType() != typeof(Rectangulo))
            {
                EsIgual = false;
            }
            else
            {
                Rectangulo Rec = (Rectangulo)obj;
                EsIgual = (_base == Rec._base) && (_altura == Rec._altura);
            }

            return EsIgual;
        }

        public override int GetHashCode()
        {
            return Convert.ToInt32(_altura * _base) * 1920;
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
        #endregion

        #region "Constructor"
        public Rectangulo()
        {
            _base = 1;
            _altura = 1;

        }
        public Rectangulo(double Base, double Alt)
        {
            if ((Base > 0) && (Alt > 0))
            {
                _base = Base;
                _altura = Alt;
            }   
            else
            {
                _base = 1;
                _altura = 1; ;
            }
        }
        #endregion
    }
}
