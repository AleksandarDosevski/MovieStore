using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace MovieStore.Controllers
{

    [Authorize(Roles = "admin")]
    public class DirectorsController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        // GET: Directors
        public IActionResult Index()
        {
            var directors = _directorService.GetDirectors();

            return View(directors);
        }

        // GET: Directors/Details/5
        public IActionResult Details(int id)
        {
            var director = _directorService.GetDirectorById(id);

            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // GET: Directors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Directors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Director director)
        {
            if (ModelState.IsValid)
            {
                _directorService.Add(director);
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }

        [HttpPost]
        public JsonResult CreateDirectorAJAX(string name, string shortDescription)
        {
            var director = new Director();

            if (name != "" || name != null && shortDescription != "" || shortDescription != null)
            {
                director.Name = name;
                director.ShortDescription = shortDescription;
                _directorService.Add(director);
            }
            return Json(director);
        }

        // GET: Directors/Edit/5
        public IActionResult Edit(int id)
        {
            var director = _directorService.GetDirectorById(id);
            if (director == null)
            {
                return NotFound();
            }
            return View(director);
        }

        // POST: Directors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Director director)
        {
            if (id != director.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _directorService.Edit(director);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(director);
        }

        // GET: Directors/Delete/5
        public IActionResult Delete(int id)
        {
            var director = _directorService.GetDirectorById(id);

            if (director == null)
            {
                return NotFound();
            }

            return View(director);
        }

        // POST: Directors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var director = _directorService.GetDirectorById(id);
            _directorService.Delete(director);

            return RedirectToAction(nameof(Index));
        }

    }
}
