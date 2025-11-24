namespace AskTyler.Settings;

public class AskTylerSettings
{
    public Uri ServiceUri { get; set; }
    public string AskTylerDbContextConnectionString { get; set; }
    public string IdentityServerUri { get; set; }
    public string ClientId { get; set; }
    public string ClientSecret { get; set; }
}