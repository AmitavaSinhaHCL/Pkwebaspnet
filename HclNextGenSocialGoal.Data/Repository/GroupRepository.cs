using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupRepository:RepositoryBase<Group>, IGroupRepository
        {
        public GroupRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IGroupRepository : IRepository<Group>
    {
    }
   
}
