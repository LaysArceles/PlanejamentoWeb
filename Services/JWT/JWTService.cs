using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace PlanejamentoWeb.Services.JWT;

public class JWTService(SecurityKey securityKey) : IJWTService
{
    public string CreateToken(ProfileAuth data)
    {
        var jwt= new JwtSecurityToken(
            claims: [

            new Claim(ClaimTypes.NameIdentifier, data.ID.ToString()),
            new Claim(ClaimTypes.Name, data.username),
            new Claim("turisticosid", data.TuristicosID.ToString())
            ],
         expires: DateTime.UtcNow.AddHours(2),
            signingCredentials: new SigningCredentials(
                securityKey,
                SecurityAlgorithms.HmacSha256Signature
            )
        );
        var handler = new JwtSecurityTokenHandler();
        return handler.WriteToken(jwt);
    }
}