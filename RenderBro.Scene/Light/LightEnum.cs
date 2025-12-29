namespace RenderBro.Core.Scene.Light;

public enum LightType : byte
{
    Area,
    Directional,
    Environment
}

public enum AreaShape : byte
{
    Rect,
    Disk,
    Sphere
}
