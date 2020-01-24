using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Mappings
{
    public class ProductMap:ClassMap<Product>
    {
        public ProductMap()
        {
            Table(@"Product");
            LazyLoad();
            Id(x=>x.Id).Column("Id");
            Map(x => x.Name).Column("Name");
            Map(x => x.Description).Column("Description");
            Map(x=>x.Price).Column("Price");
        }
    }
}
