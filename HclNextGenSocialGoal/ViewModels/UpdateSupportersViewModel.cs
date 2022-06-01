using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class UpdateSupportersViewModel
    {
        public int UpdateId { get; set; }

        public Update Update { get; set; }

        public IEnumerable<ApplicationUser> Users { get; set; }
    }
}