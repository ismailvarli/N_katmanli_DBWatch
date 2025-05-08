using DAL;
using ENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Musteriservice
    {
        private readonly MusteriDAL musteriDAL;

        public Musteriservice()
        {
            musteriDAL = new MusteriDAL();

        }

        public List<Musteri> GetAll()
        {
            return musteriDAL.GetAll();
        }

        public int Create(Musteri Entity)
        {
            return musteriDAL.Create(Entity);
        }
    }
}
