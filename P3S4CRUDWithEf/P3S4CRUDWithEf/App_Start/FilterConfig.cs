using System.Web;
using System.Web.Mvc;

namespace P3S4CRUDWithEf
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
