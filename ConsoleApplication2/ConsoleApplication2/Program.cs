using ConsoleApplication2;
using System;

class Program
    {
        static void Main()
        {
        ContactPerson p = new ContactPerson();
        p._Nume = "Chicu";
        p._Prenume = "Lilia";
        Console.WriteLine("{0},{1}",p._Prenume, p._Nume);
        Console.ReadLine();
        }
    }

