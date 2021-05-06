using System;
using System.Data;
using System.Data.SQLite;
using Dapper;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;


public class SqliteDataAccess
{
	#region Elever
	public static void AddElev(EleverModel Elev)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Execute($"INSERT INTO Elever VALUES (@Elev_Personnummer, @Namn, @Adress, @Epost, @Telefonnummer, @Klass_Namn)", Elev);
	}
	public static List<EleverModel> LoadEleverList()
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		var output = cnn.Query<EleverModel>("SELECT * FROM Elever", new DynamicParameters());
		return output.ToList();
	}

	public static void EditElev(int initialPersonnummer, int personnummer, string namn, string adress, string epost, int telefonnummer, string klass)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Execute($"UPDATE Elever SET Elev_Personnummer = {personnummer}, Namn = '{namn}', Adress = '{adress}', Epost = '{epost}', Telefonnummer = {telefonnummer}, Klass_Namn = '{klass}' ) WHERE Elev_Personnummer = '{initialPersonnummer}'");
	}

	public static EleverModel GetElev(int ElevPersonnummer)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		return cnn.QueryFirst<EleverModel>("SELECT * FROM Elever WHERE Elev_Personnummer='" + ElevPersonnummer + "'", new DynamicParameters());
	}

	public static void RemoveElev(int ElevPersonnummer)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Execute("DELETE FROM Elever WHERE Elev_Personnummer='" + ElevPersonnummer + "'");
	}
	#endregion

	#region Hushåll
	public static void GenerateHushåll(EleverModel elev, VårdnadshavareModel vårdnadshavare)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Execute($"INSERT INTO Hushåll VALUES ({elev.Elev_Personnummer}, {vårdnadshavare.Vårdnadshavare_Personnummer})");
	}
	#endregion

	#region Vårdnadshavare
	public static void AddVårdnadshavare(VårdnadshavareModel Vårdnadshavare)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Execute($"INSERT INTO Vårdnadshavare VALUES (@Vårdnadshavare_Personnummer, @Namn, @Adress, @Epost, @Telefonnummer)", Vårdnadshavare);
	}
	public static List<VårdnadshavareModel> LoadVårdnadshavareList()
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		var output = cnn.Query<VårdnadshavareModel>("SELECT * FROM Vårdnadshavare", new DynamicParameters());
		return output.ToList();
	}
	public static VårdnadshavareModel LoadVårdnadshavare(string VårdnadshavarePersonnummer)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		var output = cnn.Query<VårdnadshavareModel>("SELECT * FROM Vårdnadshavare WHERE Vårdnadshavare_Personnummer='" + VårdnadshavarePersonnummer + "'", new DynamicParameters());
		return output.ToList()[0];
	}
	public static void RemoveVårdnadshavare(string VårdnadshavarePersonnummer)
	{
		using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
		cnn.Query<VårdnadshavareModel>("DELETE FROM Vårdnadshavare WHERE Vårdnadshavare_Personnummer='" + VårdnadshavarePersonnummer + "'");
	}
	#endregion

	private static string LoadConnectionString(string id = "Default")
	{
		return ConfigurationManager.ConnectionStrings[id].ConnectionString;
	}
}

public class EleverModel
{
	public EleverModel() { }

	public EleverModel(int personnummer, string namn, string adress, string epost, int telefonnummer, string klass)
	{
		Elev_Personnummer = personnummer;
		Namn = namn;
		Adress = adress;
		Epost = epost;
		Telefonnummer = telefonnummer;
		Klass_Namn = klass;
	}

	public int Elev_Personnummer { get; set; }
	public string Namn { get; set; }
	public string Adress { get; set; }
	public string Epost { get; set; }
	public int Telefonnummer { get; set; }
	public string Klass_Namn { get; set; }

	public override string ToString()
	{
		return Namn;
	}
	public int GetPersonnummer()
	{
		return Elev_Personnummer;
	}
}

public class VårdnadshavareModel
{

	public VårdnadshavareModel() {}

	public VårdnadshavareModel(int personnummer, string namn, string adress, string epost, int telefonnummer)
	{
		Vårdnadshavare_Personnummer = personnummer;
		Namn = namn;
		Adress = adress;
		Epost = epost;
		Telefonnummer = telefonnummer;
	}

	public int Vårdnadshavare_Personnummer { get; set; }
	public string Namn { get; set; }
	public string Adress { get; set; }
	public string Epost { get; set; }
	public int Telefonnummer { get; set; }
}

public class HushållModel
{
	public int ID { get; set; }
	public int Elev_Personnummer { get; set; }
	public int Vårdnadshavare_Personnummer { get; set; }
}

