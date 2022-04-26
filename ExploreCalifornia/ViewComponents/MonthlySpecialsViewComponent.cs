using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.ViewComponents
{
    [ViewComponent] // or
    public class MonthlySpecialsViewComponent : ViewComponent // or this
    {
        public string Invoke()
        {
            return "TODO: Show Monthly Specials";
        }
    }
}
