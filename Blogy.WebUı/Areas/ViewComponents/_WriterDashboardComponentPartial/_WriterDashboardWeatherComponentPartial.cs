using Blogy.DataAccesLayer.Context;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Blogy.WebUI.Areas.ViewComponents._WriterDashboardComponentPartial
{
    public class _WriterDashboardWeatherComponentPartial : ViewComponent
    {

        public async Task <IViewComponentResult> InvokeAsync()
        {
            //Hava Durumu
            string api = "79dbc22f9cfe41e1db0958e0eef87f8e";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            return View();


        }
    }
}
