using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppDomain;
using AppPersistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ReactCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }

        //GET api/values
        //GET values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Value>>> Get()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        //GET api/values/5
        //GET values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Value>> Get(int id)
        {
            var value = await _context.Values.FindAsync(id);
            return Ok(value);
        }
    }
}