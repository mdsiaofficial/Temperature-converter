using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn

        /*
        If you have something that can help write to luizh.160@hotmail.com
        */

        /*  Program created for conversion of temperatures from ceulcius to fahrenheit or kelvin*/
 
{//1
    class Program
    {//2
        static void Main(string[] args)
        {//3
        
            Console.WriteLine("***Temperature converter***");
            Console.WriteLine("");//line break
            Console.WriteLine("");//line break
            Console.WriteLine("type it:");
            Console.WriteLine("");//line break
            Console.WriteLine("1: celsius to fahrenheit");
            Console.WriteLine("");//line break
            Console.WriteLine("2: celsius to kelvin");
            Console.WriteLine("");//line break
            Console.WriteLine("3: Fahrenheit to celsius");
            Console.WriteLine("");//line break
            Console.WriteLine("4: Fahrenheit to kelvin");
            Console.WriteLine("");//line break
            Console.WriteLine("5: kelvin to celsius");
            Console.WriteLine("");//line break
            Console.WriteLine("6: kelvin to Fahrenheit");
            Console.WriteLine("");//line break

            int num = Convert.ToInt32(Console.ReadLine());//Variable to check conversion choice

            switch (num)//Possible choices
            {//4
                case 1://celsius to fahrenheit        "F = C * 1,8 + 32"
                    Console.WriteLine("type the temperature: ");                
                    double C1 = Convert.ToDouble(Console.ReadLine());            
                    double F1 = C1 * 1.8 + 32;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in fahrenheit is: {0}" , F1);
                    break;
                    
                case 2://celsius to kelvin            "K = C + 273,15"
                    Console.WriteLine("type the temperature: ");                
                    double C2 = Convert.ToDouble(Console.ReadLine());            
                    double K2 = C2 + 273.15;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in kelvin is: {0}",K2);
                    break;

                case 3://Fahrenheit to celcius        "C = (F − 32) / 1,8"
                    Console.WriteLine("type the temperature: ");                
                    double F3 = Convert.ToDouble(Console.ReadLine());
                    double C3 = (F3 - 32) / 1.8;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in celsius is: {0}",C3);
                    break;

                case 4://Fahrenheit to kelvin        "K = (F + 459,67) / 1,8"
                    Console.WriteLine("type the temperature: ");                
                    double F4 = Convert.ToDouble(Console.ReadLine());            
                    double K4 = (F4 + 459.67) / 1.8;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in kelvin is: {0}",K4);
                    break;

                case 5://kelvin to celsius            "C = K − 273,15"
                    Console.WriteLine("type the temperature: ");                
                    double K5 = Convert.ToDouble(Console.ReadLine());            
                    double C5 = K5 - 273.15;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in celsius is: {0}",C5);
                    break;

                case 6://kelvin to Fahrenheit        "F = K × 1,8 – 459,67"
                    Console.WriteLine("type the temperature: ");                
                    double K6 = Convert.ToDouble(Console.ReadLine());            
                    double F6 = K6 * 1.8 - 459.67;
                    Console.WriteLine("");//line break
                    Console.WriteLine("temperature in fahrenheit is: {0}",F6);
                    break;

                default:
                    Console.WriteLine("Invalid inserted value");//If you enter some number thats not 1 or 6
                    break;
                    
            }//4
        }//3
    }//2
}//1
