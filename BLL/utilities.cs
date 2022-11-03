using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
  public static  class utilities
    {
        public static Clothet_bl ConfigClothesDependencies(string s)
        {
            switch (s)
            {
                case "Moke":return new Clothet_bl(new DataSource());
                case "SQL":
                default:
                    return new Clothet_bl(new SQLeDataSource());
            }
        }
    }
}
