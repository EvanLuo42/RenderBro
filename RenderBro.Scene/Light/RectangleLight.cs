using RenderBro.Core.Color;

namespace RenderBro.Core.Scene.Light;

public class RectangleLight(float intensity, Color3 color, float exposure, float colorTemperature, float width, float height) : ILight
{
    public float Intensity { get; } = intensity;

    public float Exposure { get; } = exposure;

    public Color3 Color { get; } = color;

    public float ColorTemperature { get; } = colorTemperature;

    public float Width { get; } = width;

    public float Height { get; } = height;
}