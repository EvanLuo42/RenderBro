namespace RenderBro.Core.Scene.Light;

public sealed class LightSoA(
    int count, 
    AreaLightSoA area, 
    int[] payloadIndex, 
    AreaShape[] shape,
    EnvironmentLightSoA environment, 
    DirectionalLightSoA directional)
{
    public int LightCount = count;

    public LightType[] Type = new LightType[count];

    public AreaShape[] Shape = shape;

    public int[] PayloadIndex = payloadIndex;

    public AreaLightSoA Area = area;
    public DirectionalLightSoA Directional = directional;
    public EnvironmentLightSoA Environment = environment;
}