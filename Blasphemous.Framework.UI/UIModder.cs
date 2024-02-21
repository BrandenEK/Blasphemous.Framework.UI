using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.UI;

/// <summary>
/// Provides convenient methods for creating and modifying UI elements
/// </summary>
public static class UIModder
{
    /// <summary>
    /// Contains TMP_FontAsset objects
    /// </summary>
    public static Fonts Fonts { get; private set; } = new();

    /// <summary>
    /// Contains RectTransform objects
    /// </summary>
    public static Parents Parents { get; private set; } = new();

    /// <summary>
    /// Creates a RectTransform with the specified options
    /// </summary>
    public static RectTransform Create(RectCreationOptions options)
    {
        return new GameObject().AddComponent<RectTransform>().ApplyOptions(options);
    }
}

/// <summary>
/// Contains TMP_FontAsset objects
/// </summary>
public class Fonts
{
    /// <summary> Pixelated Blasphemous font </summary>
    public Font Blasphemous { get; internal set; }

    /// <summary> Standard Arial font </summary>
    public Font Arial { get; internal set; }

    /// <summary>
    /// Locates and stores font objects
    /// </summary>
    internal void Initialize()
    {
        Blasphemous = Object.FindObjectOfType<Text>()?.font;
        Arial = Resources.GetBuiltinResource<Font>("Arial.ttf");
    }
}

/// <summary>
/// Contains RectTransform objects
/// </summary>
public class Parents
{
    /// <summary> UI holder at 360p </summary>
    public Transform CanvasStandard { get; internal set; }

    /// <summary> UI holder at 1080p </summary>
    public Transform CanvasHighRes { get; internal set; }

    /// <summary>
    /// Locates and stores transform objects
    /// </summary>
    internal void Initialize()
    {
        foreach (var canvas in Object.FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "Game UI (No Pixel Perfect)")
                CanvasHighRes = canvas.transform;
            else if (canvas.name == "Game UI")
                CanvasStandard = canvas.transform;
        }
    }
}
