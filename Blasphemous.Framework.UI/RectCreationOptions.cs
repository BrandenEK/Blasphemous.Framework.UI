using UnityEngine;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Settings used when creating a new RectTransform
/// </summary>
public class RectCreationOptions
{
    /// <summary> Default: "New Rect" </summary>
    public string Name { get; set; } = "New Rect";

    /// <summary> Default: Canvas </summary>
    public Transform Parent { get; set; } = UIModder.Parents.Canvas;

    /// <summary> Default: (0.5, 0.5) </summary>
    public Vector2 XRange { get; set; } = new Vector2(0.5f, 0.5f);

    /// <summary> Default: (0.5, 0.5) </summary>
    public Vector2 YRange { get; set; } = new Vector2(0.5f, 0.5f);

    /// <summary> Default: (0.5, 0.5) </summary>
    public Vector2 Pivot { get; set; } = new Vector2(0.5f, 0.5f);

    /// <summary> Default: (0, 0) </summary>
    public Vector2 Position { get; set; } = Vector2.zero;

    /// <summary> Default: (100, 100) </summary>
    public Vector2 Size { get; set; } = new Vector2(100, 100);
}
