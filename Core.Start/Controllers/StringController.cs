using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Start.Services;
using Microsoft.AspNetCore.Mvc;

namespace Core.Start.Controllers
{
    public class StringController : Controller
    {
        private readonly IStringService _stringService;
        public StringController(IStringService stringService)
        {
            _stringService = stringService;
        }
        public IActionResult Index()
        {
            object result = _stringService.GetDate();
            return View(result);
        }
    }
}