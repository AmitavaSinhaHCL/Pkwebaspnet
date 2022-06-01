using HclNextGenSocialGoal.Data.Infrastructure;
using HclNextGenSocialGoal.Data.Models;
using HclNextGenSocialGoal.Model.Models;
using System;
using System.Linq.Expressions;
namespace HclNextGenSocialGoal.Data.Repository
{
    public class UserRepository: RepositoryBase<ApplicationUser>, IUserRepository
        {
        public UserRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
            {
            }        
        }
    public interface IUserRepository : IRepository<ApplicationUser>
    {
        
    }
}