using FitTrackAPI.Classes;
using FitTrackAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrackAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MeasurementsController : ControllerBase
    {
        private readonly TrackContext _context;

        public MeasurementsController(TrackContext context) 
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetMeasurements([FromQuery] QueryParameters queryParameters)
        {
            IQueryable<Measurement> measurements = _context.Measurements;

            measurements = measurements
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);
                
            var PaginatedMeasurements = await measurements.ToArrayAsync();
            return Ok(PaginatedMeasurements);
        }

        [HttpGet, Route("/measurements/{id}")]
        // can also use shortcut [HttpGet("{id:int}")] :int used for typing uri variable as well
        public async Task<IActionResult> GetMeasurement(int id)
        {
            var measurement = await _context.Measurements.FindAsync(id);

            return measurement == null ? NotFound() : Ok(measurement);
        }

    }
}
