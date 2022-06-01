using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class UpdateListViewModel
    {
        public IEnumerable<UpdateViewModel> Updates { get; set; }

        public double? Target { get; set; }

        public Metric Metric { get; set; }

    }
}