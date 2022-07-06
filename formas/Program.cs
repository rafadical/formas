using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formas
{
    internal class Program
    {
        static void Main(string[] args) {
            int B, b, h, num, area;
            
            Console.WriteLine("escolha uma figura geometrica");
            Console.WriteLine("1- triangulo");
            Console.WriteLine("2-paralelogramo");
            Console.WriteLine("3-trapezio");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("coloque a base");
            b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("coloque a altura");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("coloque a base maior (no caso do trapezio");
            B = Convert.ToInt32(Console.ReadLine());

            switch (num) 
                {
                case 1:
                    area = b * h /2 ;
                    Console.WriteLine("a area do triangulo é "  + area);

                    break;
                case 2:
                    area = b * h;
                    Console.WriteLine("a area do paralelogramo é" + area);
                    break ;
                case 3: 
                    area = (B+b)*h /2 ;
                    Console.WriteLine("a area do trapezio é" +area  );
                    break;

                    



            }











            Console.ReadKey();

        }
    }
}
