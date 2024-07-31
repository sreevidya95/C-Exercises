using AutoMapper;
using LocalGym.Models;
using LocalGym.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocalGym.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    //[Authorize]have to pass authorize token in authorize tab in postman or else unauthorizes will come
    public class GymController:ControllerBase
    {
        private readonly IGymInfoRepository gymInfo;
        private readonly IMapper mapper;

        public GymController(IGymInfoRepository gymInfo, IMapper mapper)
        {
            this.gymInfo = gymInfo;
            this.mapper = mapper;
        }


        /// <summary>
        /// returns all the memebers of gym 
        /// </summary>
        /// <returns>return all records from memebers</returns>
        [HttpGet("/members")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<Modelsample>>> GetMembers()
        {
            try
            {
                var members = await gymInfo.GetMembersAsync();
                
                return Ok(mapper.Map<IEnumerable<Modelsample>>(members));
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// returns the particular record of memeber that match with id
        /// </summary>
        /// <param name="memberId">give the id of the member</param>
        /// <returns>return the data of the member that match with id</returns>
        [HttpGet("members/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Modelsample>> GetMember(int memberId)
        {
            try
            {
                var data = await gymInfo.GetMemberByIdAsync(memberId);
                
                return Ok(mapper.Map<Modelsample>(data));
            }
            catch (Exception ex) {

                return BadRequest(ex.Message);
            }

        }

    }
}
