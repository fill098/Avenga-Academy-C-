namespace NotesApp.Services.Configuration
{
    public class JwtSettings
    {
        public string SeccretKey { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public int ExpirationInMinutes { get; set; } 
    }
}
