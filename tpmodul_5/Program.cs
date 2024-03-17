using System;

using System;

public class HaloGeneric
{
    public void SapaUser(string nama)
    {
        Console.WriteLine($"Halo user {nama}");
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        Console.Write("Enter your name: ");
        string userInput = Console.ReadLine();
               
        halo.SapaUser(userInput);
    }
}

