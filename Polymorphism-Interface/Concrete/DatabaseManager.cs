using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface.Concrete
{
    public class DatabaseManager
    {
        private IDataBaseService databaseManager;

        public DatabaseManager(IDataBaseService databaseManager)
        {
            this.databaseManager = databaseManager;
        }

        public DatabaseManager()
        {

        }
        public void LoginDB()
        {
            string username, password;
            Console.WriteLine();
            Console.WriteLine("Veri Tabanı bağlantısı için");
            Console.Write("Kullanıcı adınızı girin: ");
            username = Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            password = Console.ReadLine();
            if (databaseManager.Login(username, password))
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Bilgiler hatalı...");
            }
        }
        private void Menu()
        {
            Console.WriteLine("Veri Tabanı İşlemleri");
            Console.WriteLine("1-Veri Ekle");
            Console.WriteLine("2-Veri Sil");
            Console.WriteLine("3-Veri Getir");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Tercihiniz: ");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "1":
                    Console.WriteLine("Eklemek istediniz veri : ");
                    string value = Console.ReadLine();
                    addValue(value);
                    Console.Clear();
                    break;
                case "2":
                    deleteValue();
                    break;
                    case "3":
                    Console.Clear();
                    getValue();
                    break;
                case "4":
                    CloseDB();
                    break;
                default:
                    Console.WriteLine("Hatalı Tuşlama Yapıldı...");
                    break;
            }
        }
        private void CloseDB()
        {
            databaseManager.Logout();
        }
        private void addValue(string value)
        {
            databaseManager.AddValue(value);
        }
        private void deleteValue()
        {
            databaseManager.DeleteValue();
        } 
        private void getValue()
        {
            databaseManager.GetValue();
        }








    }
}
