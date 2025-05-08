using ENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SaatDAL
    {
        private readonly DatabaseContext db;

        public SaatDAL()
        {
            db = new DatabaseContext();
        }

        public List<Saat> GetAll()
        {
            return db.saats.ToList();
        }

        public int Create(Saat yenisaat)
        {
            db.saats.Add(yenisaat);

            return db.SaveChanges();
        }

        public int Update(Saat entity)
        {
            var guncelleneceksaat = db.saats.Find(entity.SaatId);

            guncelleneceksaat.İsim = entity.İsim;
            guncelleneceksaat.Stok_Sayisi = entity.Stok_Sayisi;
            guncelleneceksaat.Fiyat = entity.Fiyat;
            guncelleneceksaat.Marka = entity.Marka;
            guncelleneceksaat.Cinsiyet = entity.Cinsiyet;

            return db.SaveChanges();
        }

        public int Remove(Saat  Entity)
        {
            var silineceksaat = db.saats.Find(Entity.SaatId);

            db.saats.Remove(silineceksaat);

            return db.SaveChanges();
        }
    }
}

