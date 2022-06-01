using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Data.Configuration
{
    public class RegistrationTokenConfiguration:EntityTypeConfiguration<RegistrationToken>
    {
        public RegistrationTokenConfiguration()
        {
            Property(r => r.Role).HasMaxLength(50);

        }
    }
}
