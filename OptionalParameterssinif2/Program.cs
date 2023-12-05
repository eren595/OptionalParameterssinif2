using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterssinif2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinifim sinifim = new Sinifim();
            sinifim.Selamla();
            sinifim.Selamla(" Defne");
        }
    }
    class Sinifim
    {
        public void Selamla(string ad = " Emre")
        {
            Console.WriteLine("Merhaba" +ad);
        }
    }
}
