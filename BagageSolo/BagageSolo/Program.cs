using System.Diagnostics.Metrics;

namespace BagageSolo;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welkom bij zwembad de golf!\n");
        //stop hier je hoofd loop

        //laat het menu zien
        // Console.WriteLine("1. Laat het aantal kluizen zien.");
        //etc.

    }
    static int LockerCount()
    {
        int count = 0;
        //vind aantal
        return count;
    }
    static int NewLocker()
    {
        //logica om nieuwe kluis te openen
        return 0;
    }
    static bool OpenLocker()
    {
        //logica om  kluis te openen
        return false;
    }
    static bool ReturnLocker()
    {
        //logica om  kluis permanent te openen
        return false;
    }
    //helper functie template voor het uitlezen van het bestand
    static List<Kluis> GetLockersFromFile()
    {
        return [];
    }
    //helper functie template voor het schrijven van het bestand
    static void SaveLockersToFile(List<Kluis> lockers)
    {
        //logica om lockers te schrijven naar bestand
    }
}
