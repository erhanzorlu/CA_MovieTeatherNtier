using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repository.Abstract
{
    public interface IRepository<T>
    {
        public string Create(T Entity);

        public string Update(T Entity);

        public string Delete(int id);

        public T FindId(int id);

        public List<T> GetAll();
  
    }
}
