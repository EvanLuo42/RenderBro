using System.Numerics;

namespace RenderBro.Core.Scene.Light;

public sealed class AreaLightSoA(
    int count,
    AreaShape[] shape,
    Vector3[] radiance,
    Matrix4x4[] localToWorld,
    Matrix4x4[] worldToLocal,
    Vector2[] rectSize,
    float[] radius)
{
    public int Count = count;

    public AreaShape[] Shape = shape;
    
    public Vector3[] Radiance = radiance;
    
    public Matrix4x4[] LocalToWorld = localToWorld;
    public Matrix4x4[] WorldToLocal = worldToLocal;
    
    public Vector2[] RectSize = rectSize;
    public float[] Radius = radius;
}