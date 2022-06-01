using PagedList;
using HclNextGenSocialGoal.Service;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class GroupsPageViewModel
    {
        public IPagedList<GroupsItemViewModel> GroupList { get; set; }

        public GroupFilter Filter { get; set; }
    }
}