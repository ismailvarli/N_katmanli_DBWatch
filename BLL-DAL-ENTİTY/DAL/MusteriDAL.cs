using ENTİTY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MusteriDAL
    {
        private readonly DatabaseContext db;

        public MusteriDAL()
        {
            db = new DatabaseContext();
        }

        public List<Musteri> GetAll()
        {
            return db.musteris.ToList();
        }

        public int Create(Musteri yenimusteri)
        {
            db.musteris.Add(yenimusteri);

            return db.SaveChanges();
        }

        public int Update(Musteri entity)
        {
            var guncellenecekmusteri = db.musteris.Find(entity.MusteriId);

            guncellenecekmusteri.İsim = entity.İsim;
            guncellenecekmusteri.Sifre = entity.Sifre;
            guncellenecekmusteri.email = entity.email;
            guncellenecekmusteri.Sifre = entity.Sifre;

            return db.SaveChanges();
        }

        public int Remove(Musteri Entity)
        {
            var silinecekkisi = db.musteris.Find(Entity.MusteriId);

            db.musteris.Remove(silinecekkisi);

            return db.SaveChanges();
        }
    }
}
