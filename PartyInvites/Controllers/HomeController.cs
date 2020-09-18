using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    
    public class HomeController : Controller
    {
        //    public static readonly ILoggerFactory MyLoggerFactory
        //= LoggerFactory.Create(builder => { builder.AddConsole(); });

        
        public CalcDbContext calcContext;

        public ILogger<CalcDbContext> Logger { get; }

        public HomeController(CalcDbContext ctx, ILogger<CalcDbContext> logger)
        {
            calcContext = ctx;
            Logger = logger;
        }

        
        public IEnumerable<Calculations> Index([FromServices] ILogger<HomeController> logger)
        {

            // MyLoggerFactory.CreateLogger("aaa").LogDebug("ya tyt");
            logger.LogInformation("ya tyt");
            return calcContext.Calculations;

        }

        //[HttpGet("{id}")]
        //public Calculation getCalc(long id)
        //{


        //    return calcContext.Calculations.Find(id);

        //}

        //[HttpPost]
        //public void SaveCalc([FromBody] Calculation calc)
        //{
        //    calcContext.Calculations.Add(calc);
        //    calcContext.SaveChanges();
        //}

        //[HttpPut]
        //public void UpdateCalc([FromBody] Calculation calc)
        //{
        //    calcContext.Calculations.Update(calc);
        //    calcContext.SaveChanges();
        //}

        //[HttpDelete]
        //public void DeleteCalc(int id)
        //{
        //    calcContext.Calculations.Remove(new Calculation { Id = id });
        //    calcContext.SaveChanges();
        //}

        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RsvpForm( GuestResponse guestResponse)
        {
            

            if (ModelState.IsValid) {
                // Return where you want to go 
            }
            else {
                ModelState.AddModelError("", "could not log in");
            }
            
            return View();
        }

    }
}
