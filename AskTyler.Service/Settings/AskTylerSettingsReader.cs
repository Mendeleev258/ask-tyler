namespace AskTyler.Settings;


public static class AskTylerSettingsReader
{
    public static AskTylerSettings Read(IConfiguration configuration)
    {
        return new AskTylerSettings()
        {
            ServiceUri = configuration.GetValue<Uri>("Uri"),
            AskTylerDbContextConnectionString = configuration.GetConnectionString("AskTylerDbContext"),
            IdentityServerUri = configuration.GetValue<string>("IdentityServerSettings:Uri"),
            ClientId = configuration.GetValue<string>("IdentityServerSettings:ClientId"),
            ClientSecret = configuration.GetValue<string>("IdentityServerSettings:ClientSecret"),
        };
    }
}