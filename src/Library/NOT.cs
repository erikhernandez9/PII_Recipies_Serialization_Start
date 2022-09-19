using System;
using System.Collections.Generic; 

namespace CompuertaLogica
{
    public class NOT : ICompuerta
    {
        public string Nombre {get;}
        public int Entrada;
        
        public NOT (string nombre)
        {
            this.Nombre = nombre;
        }
        public int Calcular()
        {
            if (this.Entrada == 1) 
            {
                return 0;
            }
            return 1;
        }
        public void AgregarEntrada(string conector, ICalculable entrada)
        {
            this.Entrada = entrada.Calcular();
        }
    }
}