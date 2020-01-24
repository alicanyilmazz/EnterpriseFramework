using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Mappings
{
    public class CommentMap: ClassMap<Comment>
    {
        public CommentMap()
        {
            Table(@"Comments");
            LazyLoad();

            Id(x => x.Id).Column("Id");
            Map(x => x.Text).Column("Text");
            Map(x => x.UserBy).Column("UserBy");
            Map(x => x.ProductId).Column("ProductId");
        }
    }
}
