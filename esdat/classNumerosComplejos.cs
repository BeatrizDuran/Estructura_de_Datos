using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esdat
{
    public class classNumerosComplejos
    {
        private double real;
        private double imaginario;
        public classNumerosComplejos(double real, double imaginario)
        {
            SetReal(real);
            SetImaginario(imaginario);
        }
        public void SetReal(double value)
        {
            this.real = value;
        }
        public double GetReal()
        {
            return this.real;
        }
        public void SetImaginario(double value)
        {
            this.imaginario = value;
        }
        public double GetImaginario()
        {
            return this.imaginario;
        }
    }
}
