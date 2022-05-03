using Labb3.API.DTOs;
using Labb3.API.Models;
using Labb3.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonRepository _personRepository;
        public PersonsController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetPersons()
        {
            var persons = _personRepository.GetAllPersons();
            if (persons != null)
            {
                return Ok(persons);
            }
            return NotFound($"dis didnt work");
        }


        [HttpGet("{id}/interest")]
        public IActionResult GetInterest(int id)
        {
            var result = _personRepository.GetPersonInterest(id);

            if (result != null)
                return Ok(result);
            return NotFound($"User ID {id} is no longer available. ");
        }


        [HttpGet("{id}")]
        public IActionResult GetSingleUSer(int id)
        {
            var result = _personRepository.GetSinglePerson(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound($"User {id} not found");
        }

        [HttpGet("{id}/link")]
        public IActionResult GetLinkByPersonId(int id)
        {
            var result = _personRepository.GetLink(id);
            if (result != null)
                return Ok(result);

            return NotFound($"Id {id} not found");
        }


        [HttpPost]
        public IActionResult AttachInterest([FromBody] InterestToAddDto interestToAddDto)
        {
            try
            {

                if (interestToAddDto == null)
                    return BadRequest();

                var interestToAdd = new Interest
                {
                    Title = interestToAddDto.Title,
                    Description = interestToAddDto.Description,
                    Links = new List<Link> { new Link { Url = interestToAddDto.Url } },
                    PersonId = interestToAddDto.PersonId
                };


                var attachedInterest = _personRepository.AttachInterest(interestToAdd);
                return CreatedAtAction(nameof(GetInterest), new { id = attachedInterest.Id }, attachedInterest);
            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "This is an error and i cant create new object do the DB");
            }


        }


        [HttpPost("attachLink")]
        public IActionResult AttachLink([FromBody] LinkToAddDto linkToAddDto)
        {
            try
            {
                if (linkToAddDto == null)
                    return BadRequest();

                var linkToAdd = new Link
                {
                    InterestId = linkToAddDto.InterestId,
                    Url = linkToAddDto.Url
                };

                var attachedLink = _personRepository.AttachLink(linkToAdd);
                return CreatedAtAction(nameof(GetLinkByPersonId), new { id = linkToAdd.InterestId }, linkToAdd);

            }

            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "This is an error");
            }
        }




    }


}


