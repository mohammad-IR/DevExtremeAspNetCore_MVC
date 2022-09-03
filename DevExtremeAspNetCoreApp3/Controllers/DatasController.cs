using DevExtremeAspNetCoreApp3.Data;
using DevExtremeAspNetCoreApp3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAspNetCoreApp3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DatasController : ControllerBase
    {
        public AppDb _db { get; set; }
        public DatasController(AppDb db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.TableTests);
        }
        [HttpPost]
        public IActionResult Post(TableTest data)
        {
            _db.TableTests.Add(data);
            _db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(TableTest data)
        {
            _db.TableTests.Update(data);
            _db.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int Id)
        {
            var data = _db.TableTests.FirstOrDefault(item => item.Id == Id);
            _db.TableTests.Remove(data);
            _db.SaveChanges();
            return Ok();
        }
    }
}
