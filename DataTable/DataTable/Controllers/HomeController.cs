// // Breeze Project
// // Created by Bartosz Rachwal. 
// // Copyright (c) 2016 Bartosz Rachwal. The National Institute of Advanced Industrial Science and Technology, Japan. All rights reserved.

using System.Web.Mvc;
using DataTable.DataRepository;
using DataTable.Models;

namespace DataTable.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataRepository repository;

        public HomeController(IDataRepository dataRepository)
        {
            repository = dataRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchTextViewModel model)
        {
            var searchText = model.SearchText;
            var searchResult = repository.Search(searchText);
            model.Entries.AddRange(searchResult);

            return PartialView("DataTable", model);
        }
    }
}