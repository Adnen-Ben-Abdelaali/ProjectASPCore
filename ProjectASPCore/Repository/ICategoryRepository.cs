using ProjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.Repository
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories();
        public Category GetCategoryById(int id);
    }
}
