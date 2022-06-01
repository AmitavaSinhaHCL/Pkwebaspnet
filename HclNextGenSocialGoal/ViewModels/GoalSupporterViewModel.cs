using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class GoalSupporterViewModel
    {
        public int GoalId { get; set; }

        public Goal Goal { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}