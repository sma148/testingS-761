using Microsoft.AspNetCore.Mvc;
using testingS761.Data;
using testingS761.Dtos;
using testingS761.Model;

namespace testingS761.Controllers
{
    [Route("api")]
    [ApiController]
    public class ScholarshipController : Controller
    {
        private readonly IWebAPIRepo _repo;

        public ScholarshipController(IWebAPIRepo repo)
        {
            _repo = repo;
        }


        [HttpPost("AddScholarshipData")]
        public ActionResult AddScholarshipData(ScholarshipDataInputDto scholarship)
        {
            bool success = _repo.AddScholarshipData(scholarship);

            if (success)
            {
                return Ok();
            } else
            {
                return NotFound("An Error Occured, please try again!");
            }
        }

        [HttpGet("getAllScholarshipData")]
        public ActionResult<IEnumerable<Row>> GetAllScholarshipData()
        {
            return Ok(_repo.GetAllScholarshipData());
        }
    }
}
