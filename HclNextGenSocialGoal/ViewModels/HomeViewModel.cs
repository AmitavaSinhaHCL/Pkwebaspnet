using System.Collections.Generic;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class HomeViewModel
    {

        public IEnumerable<NotificationsViewModel> Notification { get; set; }
        public int? Count { get; set; }

    }
}
