using System;
using System.Collections.Generic; 

namespace CompuertaLogica
{
    public class AND : ICompuerta
    {
        public string Nombre {get;}
        public Dictionary<string, int> Entradas = new Dictionary<string, int>();
        
        public AND (string nombre)
        {
            this.Nombre = nombre;
        }
        public int Calcular()
        {
            foreach (KeyValuePair<string, int> entrada in this.Entradas)
            {
                if (entrada.Value == 0)
                {
                    return 0;
                }
            }
            return 1;
        }
        public void AgregarEntrada(string conector, ICalculable entrada)
        {
            this.Entradas.Add(conector, entrada.Calcular());
        }
    }
}