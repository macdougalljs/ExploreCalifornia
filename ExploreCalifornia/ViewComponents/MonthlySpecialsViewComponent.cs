using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent] // or
    public class MonthlySpecialsViewComponent : ViewComponent // or this
    {
        private readonly BlogDataContext db;

        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke()
        {
            var specials = db.MonthlySpecials.ToArray();
            return View(specials);
        }
    }
}
