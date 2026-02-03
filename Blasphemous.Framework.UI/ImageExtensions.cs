using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.UI
{
    /// <summary>
    /// Useful methods to modify Images
    /// </summary>
    public static class ImageExtensions
    {
        internal static Image ApplyOptions(this Image image, ImageCreationOptions options)
        {
            image.sprite = options.Sprite;
            image.color = options.Color;
            image.type = options.Type;
            return image;
        }

        /// <summary> Updates the sprite </summary>
        public static Image SetSprite(this Image image, Sprite sprite)
        {
            image.sprite = sprite;
            return image;
        }

        /// <summary> Updates the color </summary>
        public static Image SetColor(this Image image, Color color)
        {
            image.color = color;
            return image;
        }

        /// <summary> Updates the type </summary>
        public static Image SetType(this Image image, Image.Type type)
        {
            image.type = type;
            return image;
        }
    }
}
