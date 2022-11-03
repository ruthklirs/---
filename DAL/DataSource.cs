using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataSource:IDataSource
    {
        void init()
        {
            clothes = new List<Clothet>();
            clothes.Add(new Clothet() { Id=0,Name="short"});
            clothes.Add(new Clothet() { Id=1,Name="dress"});
            clothes.Add(new Clothet() { Id=2,Name="futer"});
           
        }
       
        public List<Clothet> GetAll()
        {
            if(clothes == null) init();
            return clothes;
        }
        public void AddClothet(Clothet clothet)
        {
            clothes.Add(clothet);
        }

        public void RemoveClothet(int id)
        {
            Clothet curClothet=null;
            foreach (var item in clothes)
            {
                if(item.Id==id)
                    curClothet=item;

            }
            clothes.Remove(curClothet);
        }
         List<Shop> shops;
        List<Clothet> clothes;

    }
}
