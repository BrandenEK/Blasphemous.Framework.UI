﻿using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.UI
{
    /// <summary>
    /// Useful methods to modify RectTransforms
    /// </summary>
    public static class RectExtensions
    {
        /// <summary>
        /// Adds an Image component with the specified options
        /// </summary>
        public static Image AddImage(this RectTransform rect, ImageCreationOptions options)
        {
            return rect.gameObject.AddComponent<Image>().ApplyOptions(options);
        }

        /// <summary>
        /// Adds an Image component with default options
        /// </summary>
        public static Image AddImage(this RectTransform rect) => rect.AddImage(new ImageCreationOptions());

        /// <summary>
        /// Adds a Text component with the specified options
        /// </summary>
        public static Text AddText(this RectTransform rect, TextCreationOptions options)
        {
            return rect.gameObject.AddComponent<Text>().ApplyOptions(options);
        }

        /// <summary>
        /// Adds a Text component with default options
        /// </summary>
        public static Text AddText(this RectTransform rect) => rect.AddText(new TextCreationOptions());

        internal static RectTransform ApplyOptions(this RectTransform rect, RectCreationOptions options)
        {
            rect.name = options.Name;
            rect.SetParent(options.Parent, false);

            return rect
                .SetXRange(options.XRange)
                .SetYRange(options.YRange)
                .SetPivot(options.Pivot)
                .SetPosition(options.Position)
                .SetSize(options.Size);
        }

        /// <summary> Updates the x anchors </summary>
        public static RectTransform SetXRange(this RectTransform rect, float min, float max) =>
            rect.SetXRange(new Vector2(min, max));

        /// <summary> Updates the x anchors </summary>
        public static RectTransform SetXRange(this RectTransform rect, Vector2 range)
        {
            rect.anchorMin = new Vector2(range.x, rect.anchorMin.y);
            rect.anchorMax = new Vector2(range.y, rect.anchorMax.y);
            return rect;
        }

        /// <summary> Updates the y anchors </summary>
        public static RectTransform SetYRange(this RectTransform rect, float min, float max) =>
            rect.SetYRange(new Vector2(min, max));

        /// <summary> Updates the y anchors </summary>
        public static RectTransform SetYRange(this RectTransform rect, Vector2 range)
        {
            rect.anchorMin = new Vector2(rect.anchorMin.x, range.x);
            rect.anchorMax = new Vector2(rect.anchorMax.x, range.y);
            return rect;
        }

        /// <summary> Updates the pivot </summary>
        public static RectTransform SetPivot(this RectTransform rect, float x, float y) =>
            rect.SetPivot(new Vector2(x, y));

        /// <summary> Updates the pivot </summary>
        public static RectTransform SetPivot(this RectTransform rect, Vector2 pivot)
        {
            rect.pivot = pivot;
            return rect;
        }

        /// <summary> Updates the x and y position </summary>
        public static RectTransform SetPosition(this RectTransform rect, float x, float y) =>
            rect.SetPosition(new Vector2(x, y));

        /// <summary> Updates the x and y position </summary>
        public static RectTransform SetPosition(this RectTransform rect, Vector2 position)
        {
            rect.anchoredPosition = position;
            return rect;
        }

        /// <summary> Updates the width and height </summary>
        public static RectTransform SetSize(this RectTransform rect, float width, float height) =>
            rect.SetSize(new Vector2(width, height));

        /// <summary> Updates the width and height </summary>
        public static RectTransform SetSize(this RectTransform rect, Vector2 size)
        {
            rect.sizeDelta = size;
            return rect;
        }

        /// <summary> Modifies the x and y position </summary>
        public static RectTransform ChangePosition(this RectTransform rect, float x, float y) =>
            rect.ChangePosition(new Vector2(x, y));

        /// <summary> Modifies the x and y position </summary>
        public static RectTransform ChangePosition(this RectTransform rect, Vector2 position)
        {
            rect.anchoredPosition += position;
            return rect;
        }
    }
}
