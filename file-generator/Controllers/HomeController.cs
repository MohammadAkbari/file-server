using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace sample1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Index");
        }
        
        public IActionResult Write()
        {
            string path = "/files/note.txt";

            if (!System.IO.File.Exists(path))
            {
                using (var sw = System.IO.File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                }
            }

            return Ok("Write Successful");
        }
    }
}
