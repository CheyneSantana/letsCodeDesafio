using KanbanApi.Helpers;
using KanbanApi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KanbanApi
{
    [ApiController] 
    public class AuthController : ControllerBase
    {
        [AllowAnonymous]
        [HttpPost, Route("login")]
        public async Task<IActionResult> Auth([FromBody] UserLogin user)
        {
            try
            {
                string login = new Settings().GetLogin();
                string password = new Settings().GetPassword();
                string token = string.Empty;

                if (user.Login == login && user.Senha == password)
                    token = JwtAuth.GenerateToken(user);
                else
                    return BadRequest("Usuario e/ou senha inválidos");

                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
