using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupRequestRepository: RepositoryBase<GroupRequest>, IGroupRequestRepository
        {
        public GroupRequestRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IGroupRequestRepository : IRepository<GroupRequest>
    {
    }
}