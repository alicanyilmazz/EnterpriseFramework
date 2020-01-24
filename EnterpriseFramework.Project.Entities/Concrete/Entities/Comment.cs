using EnterpriseFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Entities.Concrete.Entities
{
    public class Comment : IEntity
    {
        public virtual int Id { get; set; }
        public virtual string Text { get; set; }
        public virtual string UserBy { get; set; }
        public virtual int ProductId { get; set; }
        public virtual Product product { get; set; }
    }
}
