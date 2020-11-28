using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_2_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Calcular e exibir a área de um quadrado, a partir do valor de sua aresta que será digitado. 
            Quadrado qua = new Quadrado();

            Console.WriteLine("digite a aresta do quadrado:");
            qua.setLado(double.Parse(Console.ReadLine()));
            qua.calcularArea();
            Console.WriteLine("A área do quadrado é {0}", qua.getArea());
            Console.ReadKey();
        }
    }
}
