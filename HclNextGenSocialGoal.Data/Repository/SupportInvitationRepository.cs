using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Data.Infrastructure;

namespace HclNextGenSocialGoal.Data.Repository
{
    public class SupportInvitationRepository : RepositoryBase<SupportInvitation>, ISupportInvitationRepository
    {
        public SupportInvitationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }
    public interface ISupportInvitationRepository : IRepository<SupportInvitation>
    {
    }
}
