
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
    public class SessionRepository : IRepository<Session>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();

        public string Create(Session Entity)
        {
            try
            {
                db.Sessions.Add(Entity);
                db.SaveChanges();

                return $"{Entity.SessionName} Başarıyla oluşturuldu!";
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
                db.Sessions.Remove(FindId(id));
                db.SaveChanges();

                return $"Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Session FindId(int id)
        {
            return db.Sessions.Find(id);
        }

        public List<Session> GetAll()
        {
            return db.Sessions.ToList();
        }

        public string Update(Session Entity)
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
