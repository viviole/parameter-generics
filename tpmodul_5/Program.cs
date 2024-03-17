using System;


public class HaloGeneric
{
    public void SapaUser(string nama)
    {
        Console.WriteLine("Halo user " + nama);
    }

    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
   
        Console.Write("Masukkan nama: ");
        string input = Console.ReadLine();
        halo.SapaUser(input);

        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();

        DataGeneric<string> dataNIM = new DataGeneric<string>(nim);
        dataNIM.PrintData();
    }
}

public class DataGeneric<T>
{
    private T _data;

    public DataGeneric(T data)
    {
        _data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {_data}");
    }
}