using System;

namespace ParttimeEmployeeUC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fulltime = 1;
            int Parttime = 2;

            int Emprateperhr = 20;

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == Fulltime)
            {
                emphrs = 8;
                Console.WriteLine("Employee is full time");
            }
            else if (empcheck == Parttime)
            {
                emphrs = 4;
                Console.WriteLine("Employee is part time");
            }
            else
            {
                emphrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empwage = emphrs * Emprateperhr;
            Console.WriteLine("Employee Wage : " + empwage);

            
        }
    }
}
