using DAL;
using ENTİTY;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Saatservice
    {
        private readonly SaatDAL saatDAL;

        public Saatservice()
        {
            saatDAL = new SaatDAL();

        }

        public List<Saat> GetAll()
        {
            return saatDAL.GetAll();
        }

        public int Create(Saat Entity)
        {
            return saatDAL.Create(Entity);
        }
    }
}
