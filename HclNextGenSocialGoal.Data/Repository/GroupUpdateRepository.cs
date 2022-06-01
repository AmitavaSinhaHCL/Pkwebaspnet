using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupUpdateRepository : RepositoryBase<GroupUpdate>, IGroupUpdateRepository
    {
        public GroupUpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupUpdateRepository : IRepository<GroupUpdate>
    {
    }
}