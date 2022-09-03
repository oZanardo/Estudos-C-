using Curso_CSHARP_POO;
using System;
using System.Globalization;

// Este programa foi feito usado as funções no programa principal, e não no objeto (triangulo)
// Para ver um exemplo com a função feita no objeto, vá até o programa de calculos de receita

 namespace Course{
    class Program{
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
 
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = AreaTriangulo(x.A, x.B, x.C);
            Console.WriteLine(areaX.ToString("F4"));

            double areaY = AreaTriangulo(y.A, y.B, y.C);
            Console.WriteLine(areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else if (areaX == areaY)
            {
                Console.WriteLine("Os dois triangulos tem áreas iguais");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }

        //Função
        //Sintaxe "static [o tipo da variavel] [nome da função] (as váriaveis "modelo") "
        static double AreaTriangulo(double A, double B, double C){
            double P = (A + B + C) / 2;

            double AreaT = Math.Sqrt(P * (P - A) * (P - B) * (P - C));

            return AreaT;
        }
    }
}