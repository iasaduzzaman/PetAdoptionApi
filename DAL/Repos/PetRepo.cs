using DAL.Interface;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PetRepo : Repo, IRepo<Pet, int, Pet>
    {
        public Pet Create(Pet obj)
        {
            db.Pets.Add(obj);
            return db.SaveChanges() > 0 ? obj : null;
        }

        public bool Delete(int id)
        {
            var ex = Read(id);
            if (ex == null) return false;
            db.Pets.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Pet> Read()
        {
            return db.Pets.ToList();
        }

        public Pet Read(int id)
        {
            return db.Pets.Find(id);
        }

        public Pet Update(Pet obj)
        {
            var ex = Read(obj.Id);
            if (ex == null) return null;
            db.Entry(ex).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0 ? obj : null;
        }
    }
}
