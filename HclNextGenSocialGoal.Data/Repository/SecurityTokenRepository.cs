using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class SecurityTokenRepository: RepositoryBase<SecurityToken>, ISecurityTokenRepository
        {
        public SecurityTokenRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface ISecurityTokenRepository : IRepository<SecurityToken>
    {
    }
}