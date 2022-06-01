using System.Web.Mvc;
using HclNextGenSocialGoal.Web.Core.Helpers;

namespace HclNextGenSocialGoal.Web.Core.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static UserHtmlHelper User(this HtmlHelper html)
        {
            return new UserHtmlHelper(html, new UrlHelper(html.ViewContext.RequestContext));
        }
    }
}