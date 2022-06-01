using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupCommentRepository : RepositoryBase<GroupComment>, IGroupCommentRepository
    {
        public GroupCommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupCommentRepository : IRepository<GroupComment>
    {
    }
}