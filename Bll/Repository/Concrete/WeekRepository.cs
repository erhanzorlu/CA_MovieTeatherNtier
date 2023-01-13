using Bll.Repository.Abstract;
using Dal.Context;
using Dal.Entity;
using Microsoft.EntityFrameworkCore;

namespace Bll.Repository.Concrete
{
    public class WeekRepository : IRepository<Week>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();

        public string Create(Week Entity)
        {
            try
            {
                db.Weeks.Add(Entity);
                db.SaveChanges();
               return $"{Entity.WhichWeek} eklendi!";
                
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
                db.Weeks.Remove(FindId(id));
                db.SaveChanges();
                return $"Başarıyla silindi!";

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Week FindId(int id)
        {
           return db.Weeks.Find(id);
        }

        public List<Week> GetAll()
        {
            return db.Weeks.ToList();
         
        }

        public string Update(Week Entity)
        {
            try
            {
                db.Entry(Entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();

                return "Güncelleme başarılı!";
                
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }


}
