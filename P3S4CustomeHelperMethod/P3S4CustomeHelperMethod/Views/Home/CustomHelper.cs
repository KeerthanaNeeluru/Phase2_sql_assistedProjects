using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceStack;
using System.Web.Mvc;
using TagBuilder = System.Web.Mvc.TagBuilder;

namespace P3S4CustomeHelperMethod.Views.Home
{
    public class CustomHelper
    {
        public static IHtmlString File(string id)
        {
            TagBuilder tb = new TagBuilder("input");
            tb.Attributes.Add("type", "file");
            tb.Attributes.Add("id", id);
            return MvcHtmlString(tb.ToString());
        }
    }
}
