using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace UdemyProje1.Controllers
{
    public class FolderController : Controller
    {
        [HttpGet]
        public IActionResult List()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot"));
            var folders = directoryInfo.GetDirectories();
            return View(folders);
        }
        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string folderName) 
        {
            DirectoryInfo info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (!info.Exists)
            {
                info.Create();
            }
            return RedirectToAction("List");
        }

        public IActionResult Remove(string folderName)
        {
            DirectoryInfo info = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", folderName));
            if (info.Exists)
            {
                info.Delete(true);
            }
            return RedirectToAction("List");
        }
    }
}
