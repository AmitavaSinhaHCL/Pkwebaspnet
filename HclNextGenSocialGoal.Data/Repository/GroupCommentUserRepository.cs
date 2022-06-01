using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupCommentUserRepository : RepositoryBase<GroupCommentUser>, IGroupCommentUserRepository
    {
        public GroupCommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface IGroupCommentUserRepository : IRepository<GroupCommentUser>
    {
        
    }
}
