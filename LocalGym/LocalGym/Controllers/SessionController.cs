using AutoMapper;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    //[Authorize]have to pass authorize token in authorize tab in postman or else unauthorizes will come
    public class SessionController:ControllerBase
    {
        private readonly IGymInfoRepository gymInfo;
        private readonly IMapper mapper;

        public SessionController(IGymInfoRepository gymInfo, IMapper mapper)
        {
            this.gymInfo = gymInfo;
            this.mapper = mapper;
        }
        /// <summary>
        /// returns the session record that match with memeber id
        /// </summary>
        /// <param name="id">give memeber id</param>
        /// <returns>produces the session data that matches with given member id</returns>
        [HttpGet("member/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ModelSession>>> getsessionByMembers(int id)
        {
            try
            {
                var result =await gymInfo.GetSessionByMemberIdAsync(id);
                return Ok(mapper.Map<IEnumerable<ModelSession>>(result));
            }
            catch (Exception ex) { 
                  return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// returns the session data that match with trainer id
        /// </summary>
        /// <param name="id">give trainer id</param>
        /// <returns>produces the session data that match with trainer id</returns>
        [HttpGet("trainer/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ModelSession>>> getsessionByTrainers(int id)
        {
            try
            {
                var result = await gymInfo.GetSessionByTrainerIdAsync(id);
                return Ok(mapper.Map<IEnumerable<ModelSession>>(result));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
