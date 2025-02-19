using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.Concrate;
using Blogy.DataAccesLayer.EntityFramework;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    [Authorize(Roles = "Admin")]
    public class AdminWriterController : Controller
    {
        //WriterManager writerManager =new WriterManager(new EfWriterDal());
        private readonly IWriterService _writerService;

        public AdminWriterController(IWriterService writerService)
        {
            _writerService = writerService;
        }

        public IActionResult Index()
        {
            var values= _writerService.TGetListAll();
            return View(values);
        }


        [HttpGet]
        public IActionResult CreateWriter()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWriter(WriterTable writer)
        {
            writer.Status = true;
            _writerService.TInsert(writer);
            return RedirectToAction("Index");
        }

        public IActionResult  DeleteWriter(int id)
        {
            _writerService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateWriter(int id)
        {
            var values = _writerService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateWriter(WriterTable writer)
        {
            writer.Status = true;
            _writerService.TUpdate(writer);
            return RedirectToAction("Index");
        }


    }
}
