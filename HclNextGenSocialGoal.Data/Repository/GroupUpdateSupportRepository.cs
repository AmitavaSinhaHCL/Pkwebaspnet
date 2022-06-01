using System;
using HclNextGenSocialGoal.Model.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    class GroupUpdateSupportRepository : RepositoryBase<GroupUpdateSupport>, IGroupUpdateSupportRepository
    {
        public GroupUpdateSupportRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateSupportRepository : IRepository<GroupUpdateSupport>
    {
    }
}
