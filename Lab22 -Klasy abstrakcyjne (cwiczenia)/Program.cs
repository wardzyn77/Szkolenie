using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab22__Klasy_abstrakcyjne__cwiczenia_
{
    class Program
    {
        static void Main(string[] args)
        {
            CarRobot carRobot = new CarRobot();
            Console.WriteLine(carRobot.Work());
            TrainRobot trainRobot = new TrainRobot();
            Console.WriteLine(trainRobot.Work());

            Console.ReadKey();
        }
    }
}
