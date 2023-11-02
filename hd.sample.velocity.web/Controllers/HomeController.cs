using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using hd.sample.velocity.web.Models;
using NVelocity;
using NVelocity.App;

namespace hd.sample.velocity.web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly VelocityEngine _velocityEngine;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        // Khởi tạo và cấu hình VelocityEngine
        _velocityEngine = new VelocityEngine();
        _velocityEngine.Init();
    }

    public IActionResult Index()
    {
        VelocityContext context = new VelocityContext();
        //Khai báo biến
        context.Put("variable1", "Value 1");
        context.Put("variable2", "Value 2");

        //Khai báo list
        List<string> items = new List<string> { "Item 1", "Item 2", "Item 3" };
        context.Put("items", items);
        
        var person = new 
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 30
        };

        context.Put("Person", person);


        Template template = _velocityEngine.GetTemplate("wwwroot/211/layout.html");

        System.IO.StringWriter writer = new System.IO.StringWriter();
        template.Merge(context, writer);

        string result = writer.ToString();

        ViewBag.Message = result;
        return View();
    }
}