using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.ViewComponents._BlogWriterViewComponent
{
    public class _BlogWriterComponentPartial:ViewComponent
    {
        private readonly IWriterService _writerService;

        public _BlogWriterComponentPartial(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _writerService.TGetListAll();
            return View(values);
        }
    }
}
