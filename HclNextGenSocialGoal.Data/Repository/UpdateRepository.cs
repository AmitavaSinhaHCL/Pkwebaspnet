using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class UpdateRepository: RepositoryBase<Update>, IUpdateRepository
        {
        public UpdateRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IUpdateRepository : IRepository<Update>
    {
    }
}