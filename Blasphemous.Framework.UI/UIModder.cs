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
    internal Font Default => Blasphemous;

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
    internal Transform Default => Canvas;

    /// <summary> Parent of all UI </summary>
    public Transform Canvas { get; internal set; }

    /// <summary> Parent of the main menu UI </summary>
    public Transform MainMenu => Canvas?.Find("Interfaces/MainMenuWindow_prefab(Clone)");

    /// <summary> Parent of the game logic UI </summary>
    public Transform GameLogic => Canvas?.Find("InGame/InGameWindow_prefab(Clone)");

    /// <summary>
    /// Locates and stores transform objects
    /// </summary>
    internal void Initialize()
    {
        Canvas = Object.FindObjectOfType<CanvasScaler>()?.transform;
    }
}
