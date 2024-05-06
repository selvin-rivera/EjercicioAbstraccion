using System;


namespace EjercicioAbstraccion
{
    public class Atributos : Operacion
    {

        public double N1 { get; set; }
        public double N2 { get; set; }

        public override double Division()
 
        {
            return N1 / N2;
        }

        public override double Multiplicacion()
        {
            return N1 * N2;
        }

        public override double Resta()
        {
            return N1 - 2;
        }

        public override double Suma()
        {
            return N1 + N2;
        }

        public void Imprimir ()
        {
            Console.WriteLine($"La suma es : {Suma()}");
            Console.WriteLine($"La resta es;  {Resta()}");
            Console.WriteLine($"La multiplicacion es : {Multiplicacion()}");
            Console.WriteLine($"La Division es : {Division()}");
        }
    }


}
