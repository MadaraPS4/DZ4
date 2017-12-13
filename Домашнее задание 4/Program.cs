using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Домашнее_задание_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Automobile a = new Automobile();
            Automobile[] auto = new Automobile[5];

            for(int i=0; i<auto.Length; i++)
            {
                auto[i] = new Automobile();
            }

            auto[0].SetName("Mercedes");
            auto[0].GetName();
            a.GetInfo();

            Console.ReadKey();

        }
    }
}
