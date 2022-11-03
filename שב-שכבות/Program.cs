using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothet_bl clothetMoke = BLL.utilities.ConfigClothesDependencies("Moke");
            Clothet_bl clothetSQL = BLL.utilities.ConfigClothesDependencies("SQL");
            var list= clothetMoke.GetAll();
            var list2= clothetSQL.GetAll();
           foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
