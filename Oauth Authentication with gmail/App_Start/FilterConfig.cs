using System.Web;
using System.Web.Mvc;

namespace Oauth_Authentication_with_gmail
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
