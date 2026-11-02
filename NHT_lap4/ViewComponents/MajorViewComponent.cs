

using Microsoft.AspNetCore.Mvc;
using NHT_lap4.Data;
using NHT_lap4.Models;

namespace NHT_lap4.ViewComponents
{
    public class MajorViewComponent : ViewComponent
    {
        SchoolContext db;
        List<Major> majors;
        public MajorViewComponent(SchoolContext context)
        {
            db = context;
            majors = db.Majors.ToList();
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("RenderMajor",majors);
        }
    }
}
