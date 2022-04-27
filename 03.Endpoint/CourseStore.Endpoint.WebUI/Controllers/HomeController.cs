using CourseStore.Core.ApplicationService.Courses.QueryHandlers;
using CourseStore.Core.Domain.Courses.Dtoes;
using CourseStore.Core.Domain.Courses.Queries;
using CourseStore.Endpoint.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CourseStore.Endpoint.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index([FromServices] GetCourseListHandler handler)
        {
            List<CourseListDto> courses = handler.Handle(new GetCourseList());
            return View(courses);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}