using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupUpdateUserRepository : RepositoryBase<GroupUpdateUser>, IGroupUpdateUserRepository
    {
        public GroupUpdateUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupUpdateUserRepository : IRepository<GroupUpdateUser>
    {
       
    }
}
