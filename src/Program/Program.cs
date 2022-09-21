using System;
namespace CompuertaLogica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICalculable calculable;
            IConcetable concetable;
            ICompuerta compuerta;

            Entrada ent1 = new Entrada(0);
            Entrada ent2 = new Entrada(0);
            Entrada ent3 = new Entrada(1);

            OR or1 = new OR("or-1");
            AND and1 = new AND("and-1");
            NOT not1 = new NOT("not-1");

            or1.AgregarEntrada("a",ent1);
            or1.AgregarEntrada("b",ent2);
            and1.AgregarEntrada("a",ent1);
            and1.AgregarEntrada("b",ent2);
            not1.AgregarEntrada("b",and1);

            Garaje garaje = new Garaje();

            Console.WriteLine($"Or: {or1.Calcular()}");
            Console.WriteLine($"And: {and1.Calcular()}");
            Console.WriteLine($"Not: {not1.Calcular()}");

            Console.WriteLine($"Contraseña correcta: {garaje.Comprobar(ent1, ent2, ent3)}");
        }
    }
}
