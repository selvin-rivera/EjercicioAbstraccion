using System;


namespace EjercicioAbstraccion
{
    public class Atributos : Operacion
    {

        public double N1 { get; set; }
        public double N2 { get; set; }

        public override double Division(double N1, double N2)
 
        {
            return N1 / N2;
        }

        public override double Multiplicacion(double N1, double N2)
        {
            return N1 * N2;
        }

        public override double Resta(double N1, double N2)
        {
            return N1 - 2;
        }

        public override double Suma(double N1, double N2)
        {
            return N1 + N2;
        }

        public void Imprimir ()
        {
            Console.WriteLine($"La suma es : {Suma(N1, N2)}");
            Console.WriteLine($"La resta es;  {Resta(N1, N2)}");
            Console.WriteLine($"La multiplicacion es : {Multiplicacion(N1, N2)}");
            Console.WriteLine($"La Division es : {Division(N1, N2)}");
        }
    }


}
