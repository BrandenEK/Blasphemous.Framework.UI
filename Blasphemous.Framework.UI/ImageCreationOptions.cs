using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Settings used when creating a new Image
/// </summary>
public class ImageCreationOptions
{
    /// <summary> Default: null </summary>
    public Sprite Sprite { get; set; } = null;

    /// <summary> Default: White </summary>
    public Color Color { get; set; } = Color.white;

    /// <summary> Default: Simple </summary>
    public Image.Type Type { get; set; } = Image.Type.Simple;
}
