using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czesć jak masz na imie ? ");
            string imie = Console.ReadLine();
            Console.WriteLine("a mogę prosić nazwisko ?");
            string nazwisko = Console.ReadLine();
            Console.WriteLine(" a telefon ? Pod jaki numer do Ciebie dzwonić ?");
            int telefon = Int32.Parse(Console.ReadLine());
            Console.WriteLine(" jeszcze adres email");
            string email = Console.ReadLine();
            Console.WriteLine("Ile masz lat ?");
            byte wiek = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ile ważysz ?");
            byte waga = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ile mierzysz ?");
            byte wzrost = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Twoje dane: " +
                $"imie: {imie}, nazwisko: {nazwisko}, telefon: {telefon} " +
                $" email: {email}, wiek: {wiek}, waga: {waga} " +
                $"wzrost: {wzrost}");
            Console.ReadLine();









        }
    }
}
