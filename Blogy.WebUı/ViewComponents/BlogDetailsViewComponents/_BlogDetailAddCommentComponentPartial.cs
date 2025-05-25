using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailAddCommentComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
        
    }
}
