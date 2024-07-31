using LocalGym.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace LocalGym.Controllers
{
    [Route("login")]
    [ApiController]
    public class LController : Controller
    {
        private readonly IConfiguration config;

        public LController(IConfiguration config) {
            this.config = config;
        }    
        [HttpPost]
        public ActionResult<string> ValidateUser(UserModel user)
        {
            //step1 authenicate user
            bool u = user.ValidateLogin(user);
            if (!u)
            {
                return Unauthorized();
            }
            else
            {
                //step2 authenticat user with token
                //create token
                var securitykey = new SymmetricSecurityKey(
                    Convert.FromBase64String(config["Authentication:SecretForKey"]));
                var signingCredentials = new SigningCredentials(securitykey,SecurityAlgorithms.HmacSha256);
                var claims = new List<Claim>();
                claims.Add(new Claim("given_name",user.UserName));
                claims.Add(new Claim("password", user.Password));

                var jwtsecurityToken = new JwtSecurityToken(
                     config["Authentication:Issuer"],
                     config["Authentication:Audience"],
                     claims,
                     DateTime.UtcNow,
                     DateTime.UtcNow.AddHours(1),
                     signingCredentials);
                var tokenReturn = new JwtSecurityTokenHandler().WriteToken(jwtsecurityToken);
                return Ok(tokenReturn);


            }

        }
        
    }
}
