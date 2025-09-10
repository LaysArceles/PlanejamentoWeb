using PlanejamentoWeb.Services.JWT;
using PlanejamentoWeb.Services.Password;
using PlanejamentoWeb.Services.Profiles;

namespace PlanejamentoWeb.UseCase;

public class LoginUseCase(
    IProfileService profileService,
    IPasswordService passwordService,
    IJWTService jWTService
)
{
    public async Task<Result<LoginResponse>> Do(LoginPayload payload)
    {
        var user = await profileService.GetProfile(payload.login);
        if (user is null)
            return Result<LoginResponse>.Fail("Usuario não encontrado");
        var passwordMatch = passwordService
            .Compare(payload.password, user.password);
        if (!passwordMatch)
            return Result<LoginResponse>.Fail("Usuario não encontrado");
        var JWT = jWTService.CreateToken(
            new (
                user.ID,
                user.username,
                user.touristID

            ));
        return Result<LoginResponse>.Success(new LoginResponse(JWT));
    } 
}