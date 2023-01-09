using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebapiProject.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebapiProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaController : ControllerBase
    {
        /* [HttpGet]
         public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
         {
             return await _context.Employee.ToListAsync();
         }

         // GET: api/Employees/5
         [HttpGet("{id}")]
         public async Task<ActionResult<Employee>> GetEmployee(int id)
         {
             var employee = await _context.Employee.FindAsync(id);

             if (employee == null)
             {
                 return NotFound();
             }

             return employee;
         }*/
        // GET: api/<AlphaController>
        public List<string> Mylist = new List<string>(100) ;

        /*string[] str = new string[] { "1", "sanjana", "software" };*/

        /*private readonly WebapiProjectContext _context;

        public AlphaController(WebapiProjectContext context)
        {
            _context = context;
        }*/

        

        /*public async Task<ActionResult<IEnumerable<AlphaEmployee>>> Get()
        {
            return await _context.AlphaEmployee.ToListAsync();
        }*/

        

        // GET api/<AlphaController>/5
        
        /*public async Task<ActionResult<AlphaEmployee>> Get(int id)
        {
            var obj= await _context.AlphaEmployee.FindAsync(id);

            if(obj==null)
                return NotFound();

            return obj;
        }*/


        

        // POST api/<AlphaController>
        [HttpPost]
        /*public async Task<ActionResult<AlphaEmployee>> Post(AlphaEmployee alpha)
        {
            _context.AlphaEmployee.Add(alpha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = alpha.id }, alpha);

        }*/

        public IEnumerable<string> Post([FromBody] string str)
        {
            Mylist.Add(str);
            return Mylist;
        }




        [HttpGet]
        public IEnumerable<string> Get()
        {
            //var temp = Post() ;
            return Mylist;
        }






        [HttpGet("{id}")]
        public string Get(int id)
        {
            return Mylist[id];
        }

        // PUT api/<AlphaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlphaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
