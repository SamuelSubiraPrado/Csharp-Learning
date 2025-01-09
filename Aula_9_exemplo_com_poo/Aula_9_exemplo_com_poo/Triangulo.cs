﻿using System;

namespace Aula_9_exemplo_com_poo
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double CalculoArea()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
