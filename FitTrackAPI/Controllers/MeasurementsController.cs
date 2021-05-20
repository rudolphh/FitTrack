using FitTrackAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public MeasurementsController(TrackContext context) {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Measurement> GetMeasurements()
        {
            return _context.Measurements.ToArray();
        }
    }
}
