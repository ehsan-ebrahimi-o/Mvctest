using Microsoft.AspNetCore.Mvc;
using setion5.Models;
using setion5.Models.Book;
using System.Diagnostics;
using System.Reflection;


namespace setion5.Controllers
{
    public class BookController : Controller
    {
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        public IActionResult RegisterName()
        {
            var model = new RegisterNameViewModel();
            //model.Name = "Get Book";
            return View(model);
        }
        [HttpPost]
        public IActionResult RegisterName(RegisterNameViewModel model)
        { 
            return View(model);
        }

        public IActionResult RegisterFile()
        {
            RegisterFileViewModel model = new RegisterFileViewModel();
            return View(model);
        }
        public IActionResult RegisterFile(RegisterFileViewModel model)
        {
            if (model.File != null)
            {
                using (var ms = new MemoryStream())
                {
                    model.File.CopyTo(ms);
                    var fileByte = ms.ToArray();
                    string s = Convert.ToBase64String(fileByte);
                    model.FileBase64 = s;
                }
}
            return View(model);
        }


    }
}
