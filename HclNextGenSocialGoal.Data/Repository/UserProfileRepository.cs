using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IUserProfileRepository : IRepository<UserProfile>
    {
    }
}
