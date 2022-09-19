using System;
namespace CompuertaLogica
{
    public class Program
    {

        ICalculable calculable;
        IConcetable concetable;
        ICompuerta compuerta;

        public static void Main(string[] args)
        {
            Entrada ent1 = new Entrada(1);
            Entrada ent2 = new Entrada(0);
            OR or1 = new OR("or-1");
            or1.AgregarEntrada("a",ent1);
            or1.AgregarEntrada("a",ent2);
            Console.WriteLine(or1.Calcular());
        }
    }
}
