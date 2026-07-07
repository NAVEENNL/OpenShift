
// See https://aka.ms/new-console-template for more information

using IBM.Data.Db2;

Console.WriteLine("Using DB2 .NET8 provider");


//Connection String

string connString = Environment.GetEnvironmentVariable("ConnectionString");

DB2Connection con = new DB2Connection(connString);

con.Open();

Console.WriteLine("Connection Opened successfully");
Console.WriteLine("Database Name: "+ con.Database);

con.Close();

Console.WriteLine("Connection Closed");
