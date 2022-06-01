using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class CommentUserRepository : RepositoryBase<CommentUser>, ICommentUserRepository
    {
        public CommentUserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
        
    }
    public interface ICommentUserRepository : IRepository<CommentUser>
    {
        
    }
}
