using System;
using System.Collections.Generic; 

namespace CompuertaLogica
{
    public class OR : ICompuerta
    {
        public string Nombre {get;}
        public Dictionary<string, int> Entradas = new Dictionary<string, int>();
        
        public OR (string nombre)
        {
            this.Nombre = nombre;
        }
        public int Calcular()
        {
            foreach (KeyValuePair<string, int> entrada in this.Entradas)
            {
                if (entrada.Value == 1)
                {
                    return 1;
                }
            }
            return 0;
        }
        public void AgregarEntrada(string conector, ICalculable entrada)
        {
            this.Entradas.Add(conector, entrada.Calcular());
        }
    }
}