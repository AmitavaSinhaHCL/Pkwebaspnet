using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class CommentRepository: RepositoryBase<Comment>, ICommentRepository
        {
        public CommentRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }
      
        }
    public interface ICommentRepository : IRepository<Comment>
    {    

    }
}