using System;
using HclNextGenSocialGoal.Data.Models;

namespace HclNextGenSocialGoal.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        SocialGoalEntities Get();
    }
}
