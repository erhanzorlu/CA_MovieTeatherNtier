
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
    public class TheaterRepository : IRepository<Theater>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();
        public string Create(Theater Entity)
        {
            try
            {
                db.Theaters.Add(Entity);
                db.SaveChanges();

                return $"{Entity} Başarıyla oluşturuldu!";
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
                db.Theaters.Remove(FindId(id));
                db.SaveChanges();

                return $"Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Theater FindId(int id)
        {
            return db.Theaters.Find(id);
        }

        public List<Theater> GetAll()
        {
            return db.Theaters.ToList();
        }

        public string Update(Theater Entity)
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
