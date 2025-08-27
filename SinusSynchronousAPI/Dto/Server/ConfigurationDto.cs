namespace SinusSynchronous.API.Dto.Server;

public record ConfigurationDto
{
    public string ServerName { get; set; } = string.Empty;
    public Version ServerVersion { get; set; } = new(0, 0, 0);
    public Uri ServerUri { get; set; } = new("wss://noemptyuri");
    public string? DiscordInvite { get; set; } = null;
    public string? ServerRules { get; set; } = null;
}
