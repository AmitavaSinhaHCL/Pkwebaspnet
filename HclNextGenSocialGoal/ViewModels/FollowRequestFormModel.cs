using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class FollowRequestFormModel
    {
        public string FromUserId { get; set; }

        public string ToUserId { get; set; }

        public virtual ApplicationUser FromUser { get; set; }

        public virtual ApplicationUser ToUser { get; set; }
    }
}