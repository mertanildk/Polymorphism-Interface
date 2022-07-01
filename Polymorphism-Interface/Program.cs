using Polymorphism_Interface.Concrete;
using System;

namespace Polymorphism_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            DatabaseManager database;
            Console.WriteLine("< C# Interface Örnekleri >");
            Console.WriteLine("[1]- Oracle Database Bağlantısı Kur\n[2] - Mysql Database Bağlantısı Kur}");
            Console.Write("-> Kararınız: ");
            value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:
                    database = new DatabaseManager(new OracleDatabaseManager());
                    database.LoginDB();
                    break;
                case 2:
                    database = new DatabaseManager(new MysqlDatabaseManager());
                    database.LoginDB();
                    break;
                default:
                    Console.WriteLine("Hatalı Tuşlama");
                    break;
            }
        }
    }
}