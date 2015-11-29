namespace proof_of_concept_mvc.Helper
{
    using System;
    using System.Web.Mvc;

    public static class SelectedMenuItem
    {
        public static MvcHtmlString MenuItem(this HtmlHelper htmlHelper, string action, string controller)
        {
            var className = "";
        
            var routeData = htmlHelper.ViewContext.RouteData;
            var currentAction = routeData.GetRequiredString("action");
            var currentController = routeData.GetRequiredString("controller");

            // add string.Equals(currentAction, action, StringComparison.OrdinalIgnoreCase) && to check for controller action
            if (string.Equals(currentController, controller, StringComparison.OrdinalIgnoreCase))
            {
                className = "active";
            }

            return MvcHtmlString.Create(className);
        }

    }
}