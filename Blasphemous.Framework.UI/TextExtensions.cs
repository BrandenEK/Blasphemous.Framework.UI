using UnityEngine;
using UnityEngine.UI;

namespace Blasphemous.Framework.UI
{
    /// <summary>
    /// Useful methods to modify Texts
    /// </summary>
    public static class TextExtensions
    {
        internal static Text ApplyOptions(this Text text, TextCreationOptions options)
        {
            return text
                .SetContents(options.Contents)
                .SetColor(options.Color)
                .SetFontSize(options.FontSize)
                .SetAlignment(options.Alignment)
                .SetRichText(options.UseRichText)
                .SetWrapping(options.WordWrap)
                .SetFont(options.Font);
        }

        /// <summary> Updates the contents </summary>
        public static Text SetContents(this Text text, string contents)
        {
            text.text = contents;
            return text;
        }

        /// <summary> Updates the color </summary>
        public static Text SetColor(this Text text, Color color)
        {
            text.color = color;
            return text;
        }

        /// <summary> Updates the font size </summary>
        public static Text SetFontSize(this Text text, int size)
        {
            text.fontSize = size;
            return text;
        }

        /// <summary> Updates the alignment mode </summary>
        public static Text SetAlignment(this Text text, TextAnchor alignment)
        {
            text.alignment = alignment;
            return text;
        }

        /// <summary> Updates the rich text mode </summary>
        public static Text SetRichText(this Text text, bool useRichText)
        {
            text.supportRichText = useRichText;
            return text;
        }

        /// <summary> Updates the wrapping mode </summary>
        public static Text SetWrapping(this Text text, bool wordWrap)
        {
            text.horizontalOverflow = wordWrap ? HorizontalWrapMode.Wrap : HorizontalWrapMode.Overflow;
            return text;
        }

        /// <summary> Updates the font asset </summary>
        public static Text SetFont(this Text text, Font font)
        {
            text.font = font;
            return text;
        }
    }
}
