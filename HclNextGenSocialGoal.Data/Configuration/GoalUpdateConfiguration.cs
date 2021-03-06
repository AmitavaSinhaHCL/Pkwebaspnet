using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Configuration
{
    public class GoalUpdateConfiguration : EntityTypeConfiguration<GoalUpdate>
    {
        public GoalUpdateConfiguration()
        {
            Property(g => g.Updatemsg).HasMaxLength(50);
            Property(g => g.GoalId).IsRequired();

        }
    }
}
