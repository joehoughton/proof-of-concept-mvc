namespace proof_of_concept_mvc.Helper
{
    using System.Web.Mvc;
    using System.Linq;

    public static class TwitterBootstrapHelperExtensions
    {
        public static MvcHtmlString BootstrapValidationSummary(this HtmlHelper helper, bool excludePropertyErrors, string message)
        {
            if (helper.ViewData.ModelState.Values.All(v => v.Errors.Count == 0)) return new MvcHtmlString(string.Empty);

            var errorsList = "";
            foreach (var error in helper.ViewData.ModelState.Values.Where(v => v.Errors.Count > 0))
            {
                errorsList += string.Format("<li><i class='fa fa-exclamation-triangle'></i> {0}</li>", error.Errors.First().ErrorMessage);
            }
    
            return new MvcHtmlString(errorsList);
            }
        }
}