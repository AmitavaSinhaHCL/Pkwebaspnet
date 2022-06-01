using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class SearchViewModel
    {
        public IEnumerable<GoalViewModel> Goals { get; set; }
        public IEnumerable<ApplicationUser> Users { get; set; }
        public IEnumerable<GroupViewModel> Groups { get; set;}
        public string SearchText { get; set; }
    }
}