using AutoMapper;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System.Linq.Expressions;
using System.Net;

namespace LocalGym.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    //[Authorize]have to pass authorize token in authorize tab in postman or else unauthorizes will come
    public class TrainerController:ControllerBase
    {
        private readonly IGymInfoRepository gymInfo;
        private readonly IMapper mapper;

        public TrainerController(IGymInfoRepository gymInfo,IMapper mapper)
        {
            this.gymInfo = gymInfo;
            this.mapper = mapper;
        }

        
        /// <summary>
        /// returs all the trainers data
        /// </summary>
        /// <returns>returs all the trainers data</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ModelTrainer>>> getTrainers(string message)
        {
            try
            {
                var trainer = await gymInfo.GetTrainersAsync();
                return Ok(mapper.Map<IEnumerable<ModelTrainer>>(trainer));
            }
            catch (Exception ex) {
                throw new ExceptionModel
                {
                    statusCode = HttpStatusCode.InternalServerError,
                    message = ex.Message,
                };
               
            }
        }
        /// <summary>
        /// gives the data that match with given trainer id
        /// </summary>
        /// <param name="id">give trainer id</param>
        /// <returns>gives the data that match with given trainer id</returns>
        [HttpGet("/{id}",Name ="getTrainer")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ModelTrainer>>GetTrainer(int id)
        {
            try
            {
                var trainer = await gymInfo.GetTrainerByIdAsync(id);
                return Ok(mapper.Map<ModelTrainer>(trainer));
            }
            catch (Exception ex) { 
                return NotFound(ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<ModelTrainer>> createTrainer([FromBody] ModelTrainer modelTrainer)
        {
            try
            {
                var trainer = new Trainer
                {
                    FirstName = modelTrainer.FirstName,
                    lastName = modelTrainer.LastName,
                    FeePer30Minutes = modelTrainer.FeePer30Minutes,
                    speciality = modelTrainer.speciality,
                    HireDate = modelTrainer.HireDate
                };
              
                await gymInfo.CreateTask(trainer);
                await gymInfo.saveChages();
                var createdData = mapper.Map<ModelTrainer>(trainer);
                return CreatedAtRoute("getTrainer",new { 
                 id = createdData.TrainerId
                } ,createdData);

            }
            catch (Exception ex) { 
              return BadRequest(ex.Message);
            
            
            }
          


        }
        [HttpPut("/{id}")]
        public async Task<ActionResult> updateTrainer(int id,UpdateTrainer updateTrainer)
        {
            try
            {
                var data = await gymInfo.GetTrainerByIdAsync(id);
                if (data == null)
                {
                    return NotFound();
                }
                else
                {
                    
                    mapper.Map(updateTrainer,data);
                   
                    bool t=await gymInfo.saveChages();
                    Console.WriteLine(t);
                    return NoContent();
                }
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

    }
}
