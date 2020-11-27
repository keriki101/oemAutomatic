using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using oemAutomatic.Data;
using oemAutomatic.Models;

namespace oemAutomatic.Controllers
{
    public class newsletterController : Controller
    {
        private readonly credentialContext _context;

        public newsletterController(credentialContext context)
        {
            _context = context;
        }

        // GET: newsletter
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // POST: newsletter
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Fname,Lname,Email")] credentials credentials)
        {
            if (ModelState.IsValid)
            {
                _context.Add(credentials);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(subscribed));
            }
            return View();
        }

        //GET: newsletter/subscribed

        public async Task<IActionResult> subscribed()
        {
            return View();
        }


    }
}

