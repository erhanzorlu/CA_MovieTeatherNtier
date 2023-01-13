//using CA_MovieTeatherNtier.Repository.Abstract;
//using CA_MovieTeatherNtier.Context;
//using CA_MovieTeatherNtier.Entity;
using Bll.Repository.Abstract;
using Dal.Context;
using Dal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repository.Concrete
{
    public class SaloonRepository : IRepository<Saloon>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();
        public string Create(Saloon Entity)
        {
             try
            {
                db.Saloons.Add(Entity);
                db.SaveChanges();

                return $"{Entity.SaloonName} Başarıyla oluşturuldu!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                db.Saloons.Remove(FindId(id));
                db.SaveChanges();

                return $" Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Saloon FindId(int id)
        {
            return db.Saloons.Find(id);
        }

        public List<Saloon> GetAll()
        {
            return db.Saloons.ToList();
        }

        public string Update(Saloon Entity)
        {
            try
            {
                db.Entry(Entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

                return $"Güncelleme başarılı!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
    }
}
