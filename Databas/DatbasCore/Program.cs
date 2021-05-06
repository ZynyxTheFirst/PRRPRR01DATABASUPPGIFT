using System;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        new Program().Run();
    }
    void Run()
    {
        while (true)
        {
            Console.WriteLine("save, load or quit \n>>");
            var input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "save":
                    break;
                case "load":
                    break;
                case "quit":
                    return;
                default:
                    break;
            }
        }
    }

    public static void NewElev(int personnummer, string namn, string adress, string epost, int telefonnummer, string klass)
	{
        EleverModel elev = new EleverModel(personnummer, namn, adress, epost, telefonnummer, klass);
        SqliteDataAccess.AddElev(elev);
    }

    public static void NewVårdnadshavare(int personnummer, string namn, string adress, string epost, int telefonnummer, string elev_perssonnummer)
	{
        VårdnadshavareModel vårdnadshavare = new VårdnadshavareModel(personnummer, namn, adress, epost, telefonnummer);
        SqliteDataAccess.GenerateHushåll(SqliteDataAccess.GetElev(elev_perssonnummer), vårdnadshavare);
    }

    //Fix at some point
    /*
    void Load()
    {
        var list = SqliteDataAccess.LoadElever();
        foreach (EleverModel p in list)
            Console.WriteLine($"id: {p.Elev_Personnummer}, name: {p.Namn} {p.Adress}");
    }

    //skriv om
    void Save()
    {
        Console.WriteLine("First name or quit: \n>>");
        string name = Console.ReadLine();
        if (name == "quit")
            return;

        Console.WriteLine("Last name: \n>>");
        string lastName = Console.ReadLine();

        SqliteDataAccess.AddElev(new EleverModel() { Namn = name, Adress = lastName });
    }
    */
}