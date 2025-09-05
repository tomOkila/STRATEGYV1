namespace STRATEGY.CLIENT.DTOs
{
    public record TokenResponse(string TokenType = null!, string AccessToken = null!, string RefreshToken = null!);
}
