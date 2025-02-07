namespace EComDAL.DTOs
{
    public class JWTSettingsdto
    {
        public string SecretKey { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public double TokenLifeTime { get; set; }
    }
}
