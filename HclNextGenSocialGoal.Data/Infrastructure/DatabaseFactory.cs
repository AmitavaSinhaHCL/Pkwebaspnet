using HclNextGenSocialGoal.Data.Models;

namespace HclNextGenSocialGoal.Data.Infrastructure
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private SocialGoalEntities dataContext;
    public SocialGoalEntities Get()
    {
        return dataContext ?? (dataContext = new SocialGoalEntities());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
