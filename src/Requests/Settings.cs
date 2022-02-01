using System.Text.Json;
using System.Linq;
using RestSharp;
using ValNet.Objects.Settings;

namespace ValNet.Requests;

public class Settings : RequestBase
{
    public PlayerSettings PlayerSettings { get; set; }
    public CrosshairProfiles CrosshairProfiles { get; set; }
    public Settings(RiotUser pUser) : base(pUser)
    {
        _user = pUser;
    }

    public async Task<PlayerSettings> GetPlayerSettings()
    {
        var resp = await WebsocketRequest("/player-preferences/v1/data-json/Ares.PlayerSettings", Method.GET);

        if (!resp.isSucc)
            throw new Exception("Failed to get Player Settings");

        PlayerSettings = JsonSerializer.Deserialize<PlayerSettings>(resp.content.ToString());

        return PlayerSettings;
    }

    public CrosshairProfiles GetPlayerCrosshairProfiles(PlayerSettings playerSettings)
    {
        SettingsData settings = playerSettings.Data;
        StringSetting savedProfiles = settings.StringSettings.FirstOrDefault<StringSetting>(entry => entry.settingEnum == "EAresStringSettingName::SavedCrosshairProfileData");

        if (savedProfiles == null) throw new Exception("Failed to get list of profiles (User probably only has 1 profile).");

        CrosshairProfiles = JsonSerializer.Deserialize<CrosshairProfiles>(savedProfiles.value);

        return CrosshairProfiles;

    }
}
