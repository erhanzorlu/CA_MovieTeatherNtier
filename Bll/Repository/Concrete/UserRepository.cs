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
    public class UserRepository:IRepository<User>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();
        public string Create(User Entity)
        {
            try
            {
                db.Users.Add(Entity);
                db.SaveChanges();

                return $"{Entity.UserName} Başarıyla oluşturuldu!";
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
                db.Users.Remove(FindId(id));
                db.SaveChanges();

                return $" Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public User FindId(int id)
        {
            return db.Users.Find(id);
        }

        public List<User> GetAll()
        {
            return db.Users.ToList();
        }

        public string Update(User Entity)
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
