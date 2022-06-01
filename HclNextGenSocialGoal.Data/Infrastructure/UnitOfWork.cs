using HclNextGenSocialGoal.Data.Models;

namespace HclNextGenSocialGoal.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabaseFactory databaseFactory;
        private SocialGoalEntities dataContext;

        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }

        protected SocialGoalEntities DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

        public void Commit()
        {
            DataContext.Commit();
        }
    }
}
