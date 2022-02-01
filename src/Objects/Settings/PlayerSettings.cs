using System.Text.Json.Serialization;

namespace ValNet.Objects.Settings;

public class ActionMapping
{
    public bool alt { get; set; }
    public int bindIndex { get; set; }
    public bool cmd { get; set; }
    public bool ctrl { get; set; }
    public string key { get; set; }
    public string name { get; set; }
    public bool shift { get; set; }
}

public class BoolSetting
{
    public string settingEnum { get; set; }
    public bool value { get; set; }
}

public partial class FloatSetting
{
    public string settingEnum { get; set; }
    public float value { get; set; }
}

public partial class IntSetting
{
    public string settingEnum { get; set; }
    public int value { get; set; }
}

public partial class StringSetting
{
    public string settingEnum { get; set; }
    public string value { get; set; }
}

public class SettingsData
{
    [JsonPropertyName("actionMappings")]
    public ActionMapping[] ActionMappings { get; set; }

    [JsonPropertyName("axisMappings")]
    public object[] AxisMappings { get; set; }

    [JsonPropertyName("boolSettings")]
    public BoolSetting[] BoolSettings { get; set; }

    [JsonPropertyName("floatSettings")]
    public FloatSetting[] FloatSettings { get; set; }

    [JsonPropertyName("intSettings")]
    public IntSetting[] IntSettings { get; set; }

    [JsonPropertyName("stringSettings")]
    public StringSetting[] StringSettings { get; set; }

    [JsonPropertyName("settingsProfiles")]
    public String[] SettingsProfiles { get; set; }

    public int roamingSetttingsVersion { get; set; }
}

public class PlayerSettings
{
    [JsonPropertyName("data")]
    public SettingsData Data { get; set; }

    [JsonPropertyName("modified")]
    public long Modified { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}