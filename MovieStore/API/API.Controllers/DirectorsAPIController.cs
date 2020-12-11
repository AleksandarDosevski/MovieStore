using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data;
using MovieStore.Data.Entities;
using MovieStore.Services.Service.Interfaces;

namespace MovieStore.API.API.Controllers
{
    [Route("api/DirectorsAPI")]
    [ApiController]
    public class DirectorsAPIController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorsAPIController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        // GET: api/DirectorsAPI
        [HttpGet("Directors")]
        public IEnumerable<Director> GetDirectors()
        {
            var directors = _directorService.GetDirectors();
            return directors;
        }

        // GET: api/DirectorsAPI/5
        [HttpGet("Director")]
        public IActionResult GetDirector(int id)
        {
            var director = _directorService.GetDirectorById(id);

            if (director == null)
            {
                return NotFound();
            }

            return Ok(director);
        }

        // PUT: api/DirectorsAPI/5
        [HttpPost("EditDirector")]
        public IActionResult EditDirector(int id, Director director)
        {
            if (id != director.Id)
            {
                return BadRequest();
            }

            try
            {
                _directorService.Edit(director);
                return Ok(director);
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Error occured:  {ex}.");
            }
        }

        // POST: api/DirectorsAPI
        [HttpPost("AddDirector")]
        public ActionResult<Director> CreateDirector(Director director)
        {
            _directorService.Add(director);
            //return StatusCode(201);
            return CreatedAtAction("AddDirector", new { id = director.Id }, director);
        }

        // DELETE: api/DirectorsAPI/5
        [HttpDelete("DeleteDirector")]
        public ActionResult<Director> DeleteDirector(int id)
        {
            var getDirectorById = _directorService.GetDirectorById(id);
            
            if (getDirectorById == null)
            {
                return NotFound();
            }

            _directorService.Delete(getDirectorById);

            return getDirectorById;
        }

    }
}
