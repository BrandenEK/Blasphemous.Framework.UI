# UI Framework documentation

Example text:
```cs
private void CreateText()
{
    Text t = UIModder.Create(new RectCreationOptions()
    {
        Name = "Example",
        Parent = UIModder.Parents.CanvasStandard,
        Pivot = new Vector2(0, 1),
        Position = new Vector2(50, 30)
    }).AddText(new TextCreationOptions()
    {
        Contents = "Example message",
        Font = UIModder.Fonts.Arial,
        Color = Color.black,
        Alignment = TextAnchor.UpperLeft,
        FontSize = 16
    });
}
```

Example image:
```cs
private void CreateImage(RectTransform holder, Sprite sprite)
{
    holder.AddImage(new ImageCreationOptions()
    {
        Sprite = sprite
    });
}
```