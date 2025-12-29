using System.Numerics;

namespace RenderBro.Core.Scene.Light;

public sealed class DirectionalLightSoA(int count, Vector3[] direction, Vector3[] radiance)
{
    public int Count = count;

    public Vector3[] Direction = direction;
    public Vector3[] Radiance = radiance;
}