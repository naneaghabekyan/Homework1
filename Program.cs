/* Գրիր ծրագիր, որը հարցնում է․ քո անունը, ազգանունը, քաղաքի անունը, և հետո տպում է ամբողջական նախադասություն․
using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name=Console.ReadLine();
            Console.Write("Enter your lastname: ");
            string lastname=Console.ReadLine();
            Console.Write("Enter the name of the city where you live: ");
            string city=Console.ReadLine();
            Console.WriteLine("I am {0} {1}, I live in {2}.", name, lastname, city);         
        }
    }
}
*/



/* Գրիր “Guess the Number” խաղը․ Ծրագիրը պատահական ընտրում է թիվ 1–100 միջակայքից,Օգտատերը պետք է գուշակի,Ծրագիրը ասում է՝ “մեծ թիվ է”, “փոքր թիվ է”, կամ “ճիշտ”։
using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int rand_num = random.Next(1, 101);

            Console.WriteLine("Guess the number (1-100)! ");
            int number=Convert.ToInt32(Console.ReadLine());

            if (number == rand_num)
                Console.WriteLine("Right!");
            else
            {
                Console.WriteLine(number > rand_num ?"Your number is bigger than mine.":"Your number is smaller than mine.");
                while (number != rand_num)
                {
                    Console.Write("Try again! ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number > rand_num)
                        Console.WriteLine("Your number is bigger than mine.");
                    else if(number < rand_num)
                        Console.WriteLine("Your number is smaller than mine.");
                    else
                        Console.WriteLine("Congratulations. You win!");
                }
            }
        }
    }
}
*/



/* Գրիր ծրագիր, որը օգտագործելով switch, տպում է տարվա ամիսը ըստ մուտքագրված համարի(1-12)։
using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number (1-12): ");
            int month=Convert.ToInt32(Console.ReadLine());

            switch(month)
             {
               case 1:
                    Console.WriteLine("January");
                    break;

                case 2:
                    Console.WriteLine("February");
                    break;

                case 3:
                    Console.WriteLine("March");
                    break;

                case 4:
                    Console.WriteLine("April");
                    break;

                case 5:
                    Console.WriteLine("May");
                    break;

                case 6:
                    Console.WriteLine("June");
                    break;

                case 7:
                    Console.WriteLine("July");
                    break;

                case 8:
                    Console.WriteLine("August");
                    break;

                case 9:
                    Console.WriteLine("September");
                    break;

                case 10:
                    Console.WriteLine("October");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("Invalid month");
                    break;
                }
            }
    }
}
*/



/* Գրիր ծրագիր, որը հաշվում է 1-ից մինչև N թվերի գումարը (N-ը մուտք է տալիս օգտատերը)։
using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int N=Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= N; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }
    }
}
*/




/* Գրել “Mini Calculator” 
using System;

namespace homework_1
{
    internal class Program
    {
        static void Add(double a,double b)
        {
            Console.WriteLine( a + b);
        }

        static void Substact(double a, double b)
        {
            Console.WriteLine( a - b);
        }

        static void Multiply(double a, double b)
        {
            Console.WriteLine( a*b);
        }

        static void Divide(double a, double b)
        {   if(b!=0)
                Console.WriteLine( a / b);
            else
                Console.WriteLine("The second number is 0!"); 
        }
        static void Main()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the operator: ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Add(num1, num2);
                    break;
                case '-':
                    Substact(num1, num2);
                    break;
                case '*':
                    Multiply(num1, num2);
                    break;
                case '/':
                    Divide(num1, num2);
                    break;
            }

        }
    }
}
*/




/* Գրիր մեթոդ, որը ստանում է string և վերադարձնում է այն reverse եղած տարբերակով։
using System;

namespace homework_1
{
    internal class Program
    {
        static string Reverse(string line)
        {
            string reversed = "";
            for (int i = line.Length - 1; i >= 0; i--)
            {
                reversed += line[i];
            }
            return reversed;
        }
        static void Main()
        {
            Console.Write("Enter a line: ");
            string line = Console.ReadLine();

            string result = Reverse(line);
            Console.WriteLine(result);
        }
    }
}
}
}
*/



/* Գրիր մեթոդ, որը ստուգում է, արդյո՞ք թիվը պարզ է (prime number)։
using System;

namespace homework_1
{
    internal class Program
    {
        static bool IsPrime(int val)
        {
            if(val < 2)
                return false;

            for(int i = 2; i <= Math.Sqrt(val); i++)
            {
                if(val % i == 0)
                    return false;
            }

            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if(IsPrime(num))
                Console.Write("Prime number: "); 
        }
    }
}
*/




/* Գրիր ծրագիր, որը ստուգում է, արդյո՞ք մուտքագրված թիվը զույգ է, թե կենտ։
using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int num=Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("Even number");
            else
                Console.WriteLine("Odd number");
        }
    }
}
*/




/* Գրիր ծրագիր, որը հաշվում է շրջանագծի մակերեսը։

using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the radius: ");
            double Temp_value = Convert.ToDouble(Console.ReadLine());
            Circle example = new Circle(Temp_value);

            Console.WriteLine("Area: " + example.Area());
        }
    }

    public class Circle
    {
        private double Radius;
        public Circle(double temp)
        {
            Radius = temp; 
        }

        public double Area()
        {
            return Radius*Radius*Math.PI;
        }
    }
}
*/



/* Գրիր ծրագիր, որը հաշվում է ուղղանկյան մակերեսը և պարագիծը։

using System;

namespace homework_1
{
    internal class Program
    {
        static void Main()
        {
            Rectangle example1 = new Rectangle();

            Console.Write("Enter side 1: ");
            example1.Side_1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2: ");
            example1.Side_2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Area: " + example1.Area());
            Console.WriteLine("Perimeter: " + example1.Perimeter());
        }
    }

    public class Rectangle
    {
        public double Side_1 { get; set; } 
        public double Side_2 { get; set; }

        public double Area()
        {
            return Side_1 * Side_2;
        }

        public double Perimeter() 
        { 
            return 2*(Side_2 + Side_1);
        }
    }
}

*/
