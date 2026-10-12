using System.Web;
using System.Web.Mvc;

namespace FE_FashionStore_LapTrinhTrenWeb
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
