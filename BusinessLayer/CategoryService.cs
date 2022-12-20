using DomainLayer.Entities;
using Persistence.EfCore;
using Persistence.EfCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<CategoryEntity> CategoryRepository;

        public CategoryService(IRepository<CategoryEntity> CategoryRepository )
        {
            this.CategoryRepository = CategoryRepository;
        }
        public void Add(string name)
        {
            var existCategory=CategoryRepository.Get(x=>x.Name==name);
            if (existCategory == null)
                throw new Exception("Bu isimde zaten bir kategori var.");

            CategoryRepository.Add(new CategoryEntity {Name = name});
        }

        public int Count()
        {
            return CategoryRepository.Count();
        }
    }
}
