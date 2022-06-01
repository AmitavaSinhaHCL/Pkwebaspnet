using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupUserRepository : RepositoryBase<GroupUser>, IGroupUserRepository
    {
        public GroupUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        //public IEnumerable<User> SearchUserForGroup(string searchString, int groupId)
        //{
            
        //}
    }
    public interface IGroupUserRepository : IRepository<GroupUser>
    {
        //IEnumerable<User> SearchUserForGroup(string searchString, int groupId);
    }
}
