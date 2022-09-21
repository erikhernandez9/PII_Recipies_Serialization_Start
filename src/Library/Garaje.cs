using System;
using System.Collections.Generic; 

namespace CompuertaLogica
{
    public class Garaje
    {
        public int Valor;
        public Garaje()
        {
        }

        public int Combinacion(Entrada A, Entrada B, Entrada C)
        {
            AND and1 = new AND("And 1");
            AND and2 = new AND("And 2");
            AND and3 = new AND("And 3");
            NOT not = new NOT("Not");
            OR or = new OR("Or");

            and1.AgregarEntrada("a", A);
            and1.AgregarEntrada("b", B);

            not.AgregarEntrada("a", A);
            and2.AgregarEntrada("a", not);
            not.AgregarEntrada("b", B);
            and2.AgregarEntrada("b", not);

            or.AgregarEntrada("a", and1);
            or.AgregarEntrada("b", and2);

            and3.AgregarEntrada("a", or);
            and3.AgregarEntrada("b", C);
            return and3.Calcular();
        }

        public bool Comprobar(Entrada A, Entrada B, Entrada C)
        {
            if (Combinacion(A,B,C) == 1)
            {
                return true;
            }
            return false;
        }
    }
}