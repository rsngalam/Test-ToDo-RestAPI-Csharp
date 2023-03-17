using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApiTODO.Models
{
    [Keyless]
    public class Login
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }

    }


}
