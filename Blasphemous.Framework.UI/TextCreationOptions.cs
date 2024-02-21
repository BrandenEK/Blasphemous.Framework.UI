using UnityEngine;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Settings used when creating a new TextMeshProUGUI
/// </summary>
public class TextCreationOptions
{
    /// <summary> Default: "" </summary>
    public string Contents { get; set; } = string.Empty;

    /// <summary> Default: White </summary>
    public Color Color { get; set; } = Color.white;

    /// <summary> Default: 16 </summary>
    public int FontSize { get; set; } = 16;

    /// <summary> Default: Centered </summary>
    public TextAnchor Alignment { get; set; } = TextAnchor.MiddleCenter;

    /// <summary> Default: false </summary>
    public bool WordWrap { get; set; } = false;

    /// <summary> Default: Blasphemous </summary>
    public Font Font { get; set; } = UIModder.Fonts.Blasphemous;
}
