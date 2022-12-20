using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductEntity> Products { get; set; }=new List<ProductEntity>();
    }
}
