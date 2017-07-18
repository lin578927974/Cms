using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;

namespace NNCMS.Controllers
{
    public class AccountApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("token")]
        public async Task<IActionResult> Token([FromBody] UserRegisterAuthenticate model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var token = await GetJwtSecurityToken();
            return Ok(new
            {
                token = new JwtSecurityTokenHandler().WriteToken(token),
                expiration = token.ValidTo
            });
        }

        private async Task<JwtSecurityToken> GetJwtSecurityToken()
        {
            return new JwtSecurityToken(
                issuer:"ale",
                audience:"ale",
                claims:GetTokenClaims(),
                expires:DateTime.UtcNow.AddMinutes(10),
                signingCredentials:new Microsoft.IdentityModel.Tokens.SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SB")),SecurityAlgorithms.HmacSha256)
                );
        }
        private static IEnumerable<Claim> GetTokenClaims()
        {
            return new List<Claim> {
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub,"koo")
            };
        }
    }

    public class UserRegisterAuthenticate
    {

    }
}