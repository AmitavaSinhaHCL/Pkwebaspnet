using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class FollowUserRepository : RepositoryBase<FollowUser>, IFollowUserRepository
    {
        public FollowUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        //public IEnumerable<User> SearchUserForGroup(string searchString, int groupId)
        //{

        //}
    }
    public interface IFollowUserRepository : IRepository<FollowUser>
    {
        //IEnumerable<User> SearchUserForGroup(string searchString, int groupId);
    }
}
