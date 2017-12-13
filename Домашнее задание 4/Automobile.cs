using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание_4
{
    public partial class Automobile
    {
        private string name;
        private int nomer;
        private DateTime dateOfRealease;
        private double price;
        private char klass;

        public static string Description;

        public Automobile()
        {

        }

        public Automobile(string _Name, int _Nomer, double _Price)
        {
            name = _Name;
            nomer = _Nomer;
            price = _Price;

        }

        public Automobile(DateTime date, char Klass)
        {
            dateOfRealease = date;
            klass = Klass;
        }


        static Automobile()
        {

        }


        public void GetName()
        {
            Console.WriteLine("Название машины = " + name);
        }

        public void GetPrice()
        {
            Console.WriteLine("Цена машины = " + price);
        }
        public void GetNomer()
        {
            Console.WriteLine("Номер машины = " + nomer);
        }

        public string SetName(string Name)
        {
            name = Name;
            return name;
        }

        public double SetPrice(double Price)
        {
            price = Price;
            return price;
        }
        public int SetNomer(int Nomer)
        {
            nomer = Nomer;
            return nomer;
        }


    }
}
