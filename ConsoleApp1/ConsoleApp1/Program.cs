using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            esPar(num);
            Console.ReadLine();
        }
        public static void esPar(int numRecibido)
        {
            if (numRecibido % 2 == 0)
            {
                Console.WriteLine(" Es par ");
            }
            else
            {
                Console.WriteLine(" Es Impar ");
            }
        }
        */


        /*
    static void Main(string[] args)
    {
        string figura;
        double aCircRes,aCuadRes,aTriRes;
        Console.WriteLine("¿Que deseas circulo , triangulo , cuadrado");
        figura = Console.ReadLine();


        switch (figura)
        {
            case "circulo":
                aCircRes = ACirculo();
                Console.WriteLine("El area del circulo es :" + aCircRes);
                Console.ReadLine();
                break;
            case "cuadrado":
                aCuadRes = ACuadrado();
                Console.WriteLine("El area del cuadrado es :" + aCuadRes);

                break;
            case "triangulo":
                aTriRes = ATriangulo();
                Console.WriteLine("El area del triangulo es :" + aTriRes);

                break;
            default:
                Console.WriteLine("Error nombre erroneo.");

                break;
        }
        Console.ReadLine();
    }
    public static double ACuadrado()
    {

        double arCuad,lad;
        Console.WriteLine("Ingresa el tamaño del lado del cuadrado : ");
        lad = Convert.ToDouble(Console.ReadLine());
        arCuad = lad * lad;
        return arCuad;
    }
    public static double ATriangulo()
    {

        Console.WriteLine("Ingresa lado 1 ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingresa lado 2 ");
        double h = Convert.ToDouble(Console.ReadLine());
        double aTriang = (b * h) / 2;
        return aTriang;
    }
    public static double ACirculo()
    {
        //(radio^2)*PI
        Console.WriteLine("Ingresa el radio : ");
        double acirc,pixrad;
        double radio = Convert.ToInt32(Console.ReadLine());
        const double PI = 3.1416;
        acirc = radio*radio;
        pixrad = PI * acirc;
        return pixrad;


    }
    */

        /*
    static void Main(string[] args)
    {
        int num;// cNum=0,nPrint;
        Console.WriteLine("¿Cuántos numeros quieres generar?");
        num = Convert.ToInt32(Console.ReadLine());

            PrintN(num);


    }

    public static void PrintN (int CountNum)
    {
        int limi1, limi2,  cNum = 0;
        Random rnd = new Random();
        Console.WriteLine("Ingresa el primer numero limite");
        limi1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero limite");
        limi2 = Convert.ToInt32(Console.ReadLine());

        while (CountNum >= cNum)
        {

             int limite = rnd.Next(limi1, limi2);
             Console.WriteLine("Numero random " + (cNum+1) + " es : " + limite);

             cNum++;
        }
        Console.ReadLine();
    }
    */
        static void Main(string[] args)
        {
            int nFact;

            Console.WriteLine("Ingresa el numero del que quieres sacar el factorial");
            nFact = Convert.ToInt32(Console.ReadLine());
            Factorial(nFact);

            
            
        }
        public static void Factorial(int nFactorial)
        {
            int numberInt;

            numberInt=nFactorial;
            for (int i = 1; i < nFactorial; i++)
            {
                numberInt = numberInt * i;
            }
            Console.Write("El valor es: " + numberInt);
            Console.ReadLine();
        }
     }
}
