using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Cringe
{
    public interface IShow
    {
        string[]? ShowAllDisk();
        string[]? ShowAllDir(string dir);
        string[]? MoveBack(string ndir, TextBox tb);
        void dirMaker(string dir);
        void filMaker(string dir);
        void Deletant(string date);
        void ShowAndUpdate(string? path, ListBox lb);
    }  
}
