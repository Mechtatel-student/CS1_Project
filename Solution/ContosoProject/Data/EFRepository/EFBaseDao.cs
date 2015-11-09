using System;
using System.Linq;
using System.Linq.Expressions;
using Domain.DAO;
using Domain.Entities;
using System.Data.Entity.Migrations;

namespace Data.EFRepository
{
    public class EFBaseDao
    {
        protected ProjectContext dbContext;

        public EFBaseDao(ProjectContext projContext)
        {
            dbContext = projContext ?? new ProjectContext();
        }
    }
}
