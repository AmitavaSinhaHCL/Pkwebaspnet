using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class GroupInvitationRepository : RepositoryBase<GroupInvitation>, IGroupInvitationRepository
    {
        public GroupInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface IGroupInvitationRepository : IRepository<GroupInvitation>
    {
    }
}
