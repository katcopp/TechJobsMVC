using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

        //[HttpPost]
        //[Route("/Index")]
        public IActionResult Results(string searchType, string searchTerm)
        {
            List<Dictionary<string, string>> jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
            ViewBag.columns = ListController.columnChoices; //is this needed???
            ViewBag.column = searchType;
           // List<Dictionary<string, string>> testJobs = JobData.FindByColumnAndValue("Location", "Kansas City");
            ViewBag.jobs = jobs;
            return View("Index");
        }

    }
}
