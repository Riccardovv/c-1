using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAPP
{
    class Program
    {
        static void Main(string [] args){
            Console.WriteLine("works");
            int num1= 5;
            int num2= 6;
            double num3= 2.57;
            double suma= num1 + num3;

            Console.WriteLine(suma);
            string valor1= Console.ReadLine();
            Console.WriteLine("El valor introduciod es: " + valor1);
            int valorInt= Convert.ToInt32(valor1);
            Console.WriteLine("valor int" + valorInt);
        }
    }
}