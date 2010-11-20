using System.Web.Mvc;
using Suteki.TardisBank.IoC;

namespace Suteki.TardisBank.Controllers
{
    public class AnalyticsController : LocalizedController
    {
        readonly TardisConfiguration configuration;

        public AnalyticsController(TardisConfiguration configuration)
        {
            this.configuration = configuration;
        }

        [ChildActionOnly]
        public ViewResult Index()
        {
            return View(configuration);
        }
    }
}