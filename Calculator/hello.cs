using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.New
{
    internal class class1
    {
        public void Addition()
        {
            // Console.WriteLine("Hello");
            Console.WriteLine("Give a number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give another number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());
            var addition = num1 + num2;
            Console.WriteLine("Sum= " + addition);
        }

        public void Subtraction()
        {
            Console.WriteLine("Give a number: ");
            var num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give ANother number: ");
            var num4 = Convert.ToInt32(Console.ReadLine());
            var sub = num3 - num4;
            Console.WriteLine("Subtraction: " + sub);
        }
        public void Division()
        {
            Console.WriteLine("Give a number: ");
            var num7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give another number: ");
            var num8 = Convert.ToInt32(Console.ReadLine());
            var divide = num7 / num8;
            Console.WriteLine("Division: "+ divide);
        }
        public void Concate()
        {
            Console.WriteLine("Give a number: ");
            var num5 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Give another number: ");
            var num6 = Convert.ToString(Console.ReadLine());
            var con = num5 + num6;
            Console.WriteLine("Concatenate=" + con);
        }
        public void Interpolate()
        {
            Console.WriteLine("First Name: ");
            var firstName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("LastName: ");
            var lastName = Convert.ToString(Console.ReadLine());
            var name = $"{firstName} {lastName}";
            Console.WriteLine("Hello! Your name is " + name +".");
        }

        public static void HelloWorld1()
        {
           // Console.WriteLine("Hello World11111");
        }
    }
}
