using EnterpriseFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Entities.Concrete.Entities
{
    public class Product : IEntity
    {
        public Product()
        {
            comments = new List<Comment>();
        }
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual List<Comment> comments { get; set; }
    }
}
