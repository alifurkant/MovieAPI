﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieAPI.BLL.Models.DTOs.ActorDTOs;
using MovieAPI.BLL.Services.Abstract;
using MovieAPI.Models.Entities;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService actorService;

        public ActorController(IActorService actorService)
        {
            this.actorService = actorService;
        }
        [HttpGet]
        public ActionResult GetActors()
        {
            return Ok(actorService.GetAll());
        }
        [HttpPost]
        public ActionResult CreateActor(CreateActorDTO actorDTO)
        {
            Actor actor = new()
            {
                Name = actorDTO.Name,
                BirthDate = actorDTO.BirthDate
            };
            return Ok(actorService.Add(actor));
        }
        [HttpPut]
        public ActionResult UpdateActor(UpdateActorDTO actorDTO)
        {
            Actor actor = new()
            {
                Name = actorDTO.Name,
                BirthDate = actorDTO.BirthDate,
                Id = actorDTO.Id
            };
            if(actorService.Update(actor))
            {
                return Ok(actor);
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public ActionResult DeleteActor(int id)
        {
            if (actorService.Delete(id))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
