using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_De_Temperatura
{
    public class Calculo
    {
        private double F, K, C;

        public void CalculoF(string C)
        {
            this.C = double.Parse(C);
            F = double.Parse(C) * 1.8 + 32;
        }


        public void CalculoK(string C)
        {
            this.C = double.Parse(C);
            K = double.Parse(C) + 273.15;
        }


        public void CalculoFC(string F)
        {
            this.F = double.Parse(F);
            C = (double.Parse(F) - 32) / 1.8;
        }


        public void CalculoFK(string f)
        {
            this.F = double.Parse(f);
            K = (double.Parse(f) - 32) / 1.8 + 273.15;
        }

        public void CalculoKC(string K)
        {
            this.K = double.Parse(K);
            C = double.Parse(K) - 273.15;
        }

        public void CalculoKF(string K) 
        {
            this.K = double.Parse(K);
            F = 1.8 * (double.Parse(K) - 273) + 32;
        }

        public double ResulF()
        {
            return F;
        }

        public double ResulC()
        {
            return C;
        }

        public double ResulK()
        {
            return K;
        }

    }
}
