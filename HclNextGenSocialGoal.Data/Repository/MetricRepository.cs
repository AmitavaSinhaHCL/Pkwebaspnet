using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Model.Models;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class MetricRepository: RepositoryBase<Metric>, IMetricRepository
        {
        public MetricRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }           
        }
    public interface IMetricRepository : IRepository<Metric>
    {
    }
}