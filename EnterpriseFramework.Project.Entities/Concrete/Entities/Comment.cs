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
        public int Id { get; set; }
        public string Text { get; set; }
        public string UserBy { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}
