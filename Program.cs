using System;
using EncapsulamentoPOO.classes;

namespace EncapsulamentoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard mc = new MasterCard();
            
            System.Console.WriteLine(mc.Bandeira);
        }
    }
}
