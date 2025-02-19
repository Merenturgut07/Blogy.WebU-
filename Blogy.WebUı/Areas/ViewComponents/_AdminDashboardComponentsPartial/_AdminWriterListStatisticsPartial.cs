using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.ViewComponents._AdminDashboardComponentsPartial
{
    public class _AdminWriterListStatisticsPartial:ViewComponent
    {
        private readonly IWriterService _writerService;

        public _AdminWriterListStatisticsPartial(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _writerService.TGetListAll().OrderByDescending(x => x.WriterTableId).Take(5).ToList();
            return View(values);
        }
    }
}
