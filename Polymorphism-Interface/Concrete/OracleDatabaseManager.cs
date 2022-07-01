using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface.Concrete
{
    internal class OracleDatabaseManager : IDataBaseService
    {
        private string value, userName = "oracle", password = "admin", mark = new string('-', 6);
        public void AddValue(string value)
        {
            this.value = value;
        }

        public void DeleteValue()
        {
            this.value = null;
            Console.WriteLine("silindi");
        }

        public void GetValue()
        {
            Console.WriteLine("Veri Getirildi");
        }

        public bool Login(string userName, string password)
        {
            if (this.userName == userName && this.password == password)
            {
                return true;

            }
            return false;
        }

        public void Logout()
        {
            Console.WriteLine("çıkış yapıldı");
            Environment.Exit(0);
        }
    }
}
