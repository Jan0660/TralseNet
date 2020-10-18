using System;
using System.Xml.Linq;
using Jan0660.TralseNet;
namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                //Qoolean qool = new Qoolean();
                Qoolean qool;
                Qoolean qool2;
                if (false | qool2)
                    Console.WriteLine("qool true");
                else
                    Console.WriteLine("qool false");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
