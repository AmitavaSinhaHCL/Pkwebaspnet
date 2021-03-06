using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;


namespace HclNextGenSocialGoal.Data.Configuration
{
    public class UpdateSupportConfiguration:EntityTypeConfiguration<UpdateSupport>
    {
        public UpdateSupportConfiguration()
        {
            Property(u => u.UpdateId).IsRequired();
            Property(u => u.UserId).IsMaxLength();
            Property(u => u.UpdateSupportedDate).IsRequired();
        }
    }
}
