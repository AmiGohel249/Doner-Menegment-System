using System.Web;
using System.Web.Mvc;

namespace Sky_Blue_Set_Solved_042
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
