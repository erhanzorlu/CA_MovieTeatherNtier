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
    public class CategoryRepository : IRepository<Category>
    {
        MovieTheaterDbContext db = new MovieTheaterDbContext();
        public string Create(Category Entity)
        {
            try
            {
                db.Categories.Add(Entity);
                db.SaveChanges();

                return $"{Entity.CategoryName} Başarıyla oluşturuldu!";
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
                db.Categories.Remove(FindId(id));
                db.SaveChanges();

                return "Başarıyla silindi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public Category FindId(int id)
        {
            return db.Categories.Find(id);
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public string Update(Category Entity)
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
