using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Clothet_bl
    {
        private DataSource mokeDataSource;
        private SQLeDataSource sQLeDataSource;

        public Clothet_bl(IDataSource dataSource)
        {
        }

     

        public List<Clothet> GetAll()
        {
            DAL.DataSource data = new DAL.DataSource();
            var list=data.GetAll();
            return list;
        }
    }
}
