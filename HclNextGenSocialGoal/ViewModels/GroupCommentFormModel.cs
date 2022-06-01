using System.ComponentModel.DataAnnotations;
using HclNextGenSocialGoal.Model.Models;

namespace HclNextGenSocialGoal.Web.ViewModels
{
    public class GroupCommentFormModel
    {
        [Required(ErrorMessage = "*")]
        public string CommentText { get; set; }

        public int GroupUpdateId { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }

    }
}