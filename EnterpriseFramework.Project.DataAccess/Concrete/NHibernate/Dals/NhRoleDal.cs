﻿using EnterpriseFramework.Core.DataAccess.NHibernate;
using EnterpriseFramework.Project.DataAccess.Abstract;
using EnterpriseFramework.Project.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.DataAccess.Concrete.NHibernate.Dals
{
    public class NhRoleDal: NhEntityRepositoryBase<Role>, IRoleDal
    {
        public NhRoleDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
