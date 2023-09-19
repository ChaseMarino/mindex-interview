using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodeChallenge.Services;
using CodeChallenge.Models;

namespace CodeChallenge.Controllers
{
    [ApiController]
    [Route("api/compensation")]
    public class CompensationController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ICompensationService _compensationService;

        public CompensationController(ILogger<CompensationController> logger, ICompensationService compensationService)
        {
            _logger = logger;
            _compensationService = compensationService;
        }

        // GET api/compensation/{employeeId}
        [HttpGet("{employeeId}")]
        public ActionResult<Compensation> GetByEmployeeId(string employeeId)
        {
            var compensation = _compensationService.Get(employeeId);
            if (compensation == null) return NotFound();
            return Ok(compensation);
        }

        // POST api/compensation
        [HttpPost]
        public ActionResult<Compensation> CreateCompensation([FromBody] Compensation compensation)
        {
            _compensationService.Add(compensation);
            return CreatedAtAction(nameof(GetByEmployeeId), new { employeeId = compensation.EmployeeId }, compensation);
        }
    }
}
