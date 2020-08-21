using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Parks.Models;
using Microsoft.EntityFrameworkCore;

namespace Parks.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NationalsController : ControllerBase
  {
    private ParksContext _db;

    public NationalsController(ParksContext db)
    {
      _db = db;
    }

    // GET api/nationals
    [HttpGet]
    public ActionResult<IEnumerable<National>> Get()
    {
      return _db.Nationals.ToList();
    }

    // POST api/nationals
    [HttpPost]
    public void Post([FromBody] National national)
    {
      _db.Nationals.Add(national);
      _db.SaveChanges();
    }

    // GET api/nationals
    [HttpGet("{id}")]
    public ActionResult<National> Get(int id)
    {
      return _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
    }

    // PUT api/nationals
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] National national)
    {
      national.NationalId = id;
      _db.Entry(national).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // DELETE api/nationals
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var nationalToDelete = _db.Nationals.FirstOrDefault(entry => entry.NationalId == id);
      _db.Nationals.Remove(nationalToDelete);
      _db.SaveChanges();
    }
  }
}