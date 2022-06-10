using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();

        public IActionResult Index()

        {


            List<Suppliers> suppliersList = siemensContext.Suppliers.ToList();



            return View(suppliersList);
        }

        public IActionResult Detail(int id)
        {

            var idSup = siemensContext.Suppliers.FirstOrDefault(q => q.Id == id);


            return View(idSup);
        }
    }
}

