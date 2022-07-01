using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Interface
{
    public interface IDataBaseService
    {
        bool Login(string userName, string password);
        void Logout();
        void AddValue(string value);
        void DeleteValue();
        void GetValue();



    }
}
