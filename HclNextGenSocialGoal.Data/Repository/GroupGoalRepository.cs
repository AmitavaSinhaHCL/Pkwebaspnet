using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;


namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupGoalRepository : RepositoryBase<GroupGoal>, IGroupGoalRepository
    {
        public GroupGoalRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupGoalRepository : IRepository<GroupGoal>
    {
    }
}
