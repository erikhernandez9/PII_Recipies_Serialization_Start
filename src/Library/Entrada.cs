using System;
using System.Collections.Generic; 

namespace CompuertaLogica
{
    public class Entrada : ICalculable
    {
        public int Valor;
        public Entrada(int valor)
        {
            this.Valor = valor;
            Calcular();
        }

        public int Calcular()
        {
            return this.Valor;
        }
    }
}