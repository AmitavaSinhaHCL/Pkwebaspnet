using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class GroupUpdateSupportersViewModel
    {
        public int GroupUpdateId { get; set; }

        public GroupUpdate GroupUpdate { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}