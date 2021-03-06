using HclNextGenSocialGoal.Model.Models;
using HclNextGenSocialGoal.Service;
using HclNextGenSocialGoal.Web.Core.Models;
using HclNextGenSocialGoal.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace HclNextGenSocialGoal.Web.Controllers
{
    [Authorize]
    public class EmailRequestController : Controller
    {
        //
        // GET: /EmailRequest/
        private readonly ISecurityTokenService securityTokenService;
        public readonly IGroupUserService groupUserService;
        public readonly ISupportService supportService;
        public readonly IGroupInvitationService groupInvitationService;

        public EmailRequestController(ISecurityTokenService securityTokenService, IGroupUserService groupUserService, ISupportService supportService, IGroupInvitationService groupInvitationService)
        {
            this.securityTokenService = securityTokenService;
            this.groupUserService = groupUserService;
            this.supportService = supportService;
            this.groupInvitationService = groupInvitationService;
        }

        public ActionResult AddGroupUser()
        {
            Guid groupIdToken = (Guid)TempData["grToken"];
            var groupId = securityTokenService.GetActualId(groupIdToken);
            GroupUser newGroupUser = new GroupUser()
            {
                UserId = User.Identity.GetUserId(),
                GroupId = groupId,
                Admin = false
            };
            groupUserService.CreateGroupUser(newGroupUser, groupInvitationService);
            securityTokenService.DeleteSecurityToken(groupIdToken);
            SocialGoalSessionFacade.Remove(SocialGoalSessionFacade.JoinGroupOrGoal);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddSupportToGoal()
        {
            Guid goalIdToken = (Guid)TempData["goToken"];
            var goalId = securityTokenService.GetActualId(goalIdToken);
            supportService.CreateSupport(new Support() { UserId = User.Identity.GetUserId(), GoalId = goalId, SupportedDate = DateTime.Now });
            securityTokenService.DeleteSecurityToken(goalIdToken);
            SocialGoalSessionFacade.Remove(SocialGoalSessionFacade.JoinGroupOrGoal);
            return RedirectToAction("Index", "Home");
        }
    }
}