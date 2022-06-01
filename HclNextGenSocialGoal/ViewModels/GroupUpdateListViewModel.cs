using System;
using System.Collections.Generic;
using HclNextGenSocialGoal.Model.Models;
using System.Linq;
using System.Web;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class GroupUpdateListViewModel
    {
        public IEnumerable<GroupUpdateViewModel> GroupUpdates { get; set; }

        public double? Target { get; set; }

        public Metric Metric { get; set; }
    }
}