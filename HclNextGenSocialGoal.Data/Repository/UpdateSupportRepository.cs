using System;
using HclNextGenSocialGoal.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    class UpdateSupportRepository : RepositoryBase<UpdateSupport>, IUpdateSupportRepository
    {
        public UpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IUpdateSupportRepository : IRepository<UpdateSupport>
    {
    }
}
