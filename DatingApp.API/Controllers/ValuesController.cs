
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    //when we browse to local host, we only use "value" controller, is a place holder and removed from the class name: localhost:5000/api/values
   [Authorize(AuthenticationSchemes = "Bearer")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase // this works without view support, because we get our view from our angular app
    {
        // GET api/values
         [AllowAnonymous] 
        [HttpGet]   
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;

        }
        // GET api/values/5
        [AllowAnonymous] //means that we can get a single item without an access token
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id == id);
            return Ok(value);
        }

        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
