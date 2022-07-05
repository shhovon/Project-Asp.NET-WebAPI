using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    class BuyerRepos : IRepository<buyer, int>
    {
        landSellingEntities db;
        public BuyerRepos(landSellingEntities db)
        {
            this.db = db;
        }
        public bool Add(buyer obj)
        {
            db.buyers.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(buyer obj)
        {
            throw new NotImplementedException();
        }

        public buyer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<buyer> Get()
        {
            return db.buyers.ToList();
        }
    }
}
