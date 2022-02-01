namespace ValNet.Objects.Settings;

public partial class LineSettings
{
    public float LineThickness { get; set; }
    public float LineLength { get; set; }
    public float LineOffset { get; set; }
    public bool bShowMovementError { get; set; }
    public bool bShowShootingError { get; set; }
    public bool bShowMinError { get; set; }
    public float Opacity { get; set; }
    public bool bShowLines { get; set; }
    public float firingErrorScale { get; set; }
    public float movementErrorScale { get; set; }
}


public partial class CrosshairColor
{
    public byte R { get; set; }
    public byte G { get; set; }
    public byte B { get; set; }
    public byte A { get; set; }
}

public partial class SniperSettings
{
    public CrosshairColor CenterDotColor { get; set; }
    public float CenterDotSize { get; set; }
    public float CenterDotOpacity { get; set; }
    public bool bDisplayCenterDot { get; set; }
}

public class ProfileSettings
{
    public CrosshairColor Color { get; set; }
    public bool bHasOutline { get; set; }
    public float OutlineThickness { get; set; }
    public CrosshairColor OutlineColor { get; set; }
    public float OutlineOpacity { get; set; }
    public float CenterDotSize { get; set; }
    public float CenterDotOpacity { get; set; }
    public bool bDisplayCenterDot { get; set; }
    public bool bFixMinErrorAcrossWeapons { get; set; }
    public LineSettings InnerLines { get; set; }
    public LineSettings OuterLines { get; set; }

}

public class CrosshairProfile
{
    public ProfileSettings Primary { get; set; }
    public ProfileSettings ADS { get; set; }
    public SniperSettings Sniper { get; set; }
    public bool bUsePrimaryCrosshairForADS { get; set; }
    public bool bUseCustomCrosshairOnAllPrimary { get; set; }
    public bool bUseAdvancedOptions { get; set; }

    public string ProfileName { get; set; }
}

public class CrosshairProfiles
{
    public int CurrentProfile { get; set; }
    public List<CrosshairProfile> Profiles { get; set; }
}