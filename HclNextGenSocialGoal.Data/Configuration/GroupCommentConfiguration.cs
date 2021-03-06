using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using HclNextGenSocialGoal.Model.Models;


namespace HclNextGenSocialGoal.Data.Configuration
{
    public class GroupCommentConfiguration: EntityTypeConfiguration<GroupComment>
    {
        public GroupCommentConfiguration()
        {
            Property(g => g.GroupUpdateId).IsRequired();
            Property(g => g.CommentText).IsMaxLength();
            Property(g => g.CommentDate).IsRequired();
        }
    }
}
