
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
    public class MovieRepository : IRepository<Movie>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();
        public string Create(Movie Entity)
        {
            try
            {
                db.Movies.Add(Entity);
                db.SaveChanges();

                return $"{Entity.MovieName} Başarıyla oluşturuldu!";
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
                db.Movies.Remove(FindId(id));
                db.SaveChanges();

                return $" Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Movie FindId(int id)
        {
            return db.Movies.Find(id);
        }

        public List<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public string Update(Movie Entity)
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
