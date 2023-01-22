using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private IPetRepository _petRepository;
        private object createRequest;

        /*public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }*/

        [HttpPost("create")]
        public ActionResult<int> Create([FromBody] CreatePetRequest createPetRequest)
        {
            #region
            /*int res = _petRepository.Create(new Pet
            {
                ClientId = createPetRequest.ClientId,
                Name = createPetRequest.Name,
                Birthday = createPetRequest.Birthday,
            });
            return Ok(res);*/
            #endregion
            if (createPetRequest.Birthday < DateTime.Now.AddYears(-25) || createPetRequest.Name.Length < 3)
            {
                return BadRequest(0); // BadRequestObjectResult : 400
            }
            return Ok(1); // OkObjectResult : 200
        }

        [HttpPut("update")]
        public ActionResult<int> Update([FromBody] UpdatePetRequest updateRequest)
        {
            #region
            /*int res = _petRepository.Update(new Pet
            {
                PetId = updateRequest.PetId,
                ClientId = updateRequest.ClientId,
                Name = updateRequest.Name,
                Birthday = updateRequest.Birthday,
            });
            return Ok(res);*/
            #endregion
            if (updateRequest.Birthday < DateTime.Now.AddYears(-25) || updateRequest.Name.Length < 3)
            {
                return BadRequest(0); // BadRequestObjectResult : 400
            }
            return Ok(1);
        }

        [HttpDelete("delete")]
        public ActionResult<int> Delete(int petId)
        {
            #region
            /*int res = _petRepository.Delete(petId);
            return Ok(res);*/
            #endregion
            if (petId <= 0)
            {
                return BadRequest(0);
            }
            return Ok(1);
        }

        [HttpGet("get-all")]
        public ActionResult<List<Pet>> GetAll()
        {
            //return Ok(_petRepository.GetAll());
            return Ok(new List<Pet>());
        }

        [HttpGet("get-by-id")]
        public ActionResult<Pet> GetById(int petId)
        {
            //return Ok(_petRepository.GetById(petId));
            if (petId <= 0)
            {
                return BadRequest(0);
            }
            return Ok(new Pet());
        }
    }
}
