using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Configuration
{
    public class FollowUserConfiguration: EntityTypeConfiguration<FollowUser>
    {
        public FollowUserConfiguration()
        {
            Property(f => f.Accepted).IsRequired();
            Property(f => f.AddedDate).IsRequired();
        }
    }
}
