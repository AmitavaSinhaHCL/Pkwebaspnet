using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Configuration
{
    public class GroupUpdateUserConfiguration:EntityTypeConfiguration<GroupUpdateUser>
    {
        public GroupUpdateUserConfiguration()
        {
            Property(g => g.GroupUpdateUserId).IsRequired();
            Property(g => g.UserId).IsRequired();
        }
    }
}
