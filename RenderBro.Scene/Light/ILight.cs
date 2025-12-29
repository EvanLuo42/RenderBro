using RenderBro.Core.Color;

namespace RenderBro.Core.Scene.Light;

public interface ILight
{
    /// <summary>
    /// Scales the power of the light linearly.
    /// </summary>
    float Intensity { get; }

    /// <summary>
    /// Scales the power of the light exponentially as a power of 2 (similar
    /// to an F-stop control over exposure).
    /// </summary>
    float Exposure { get; }

    /// <summary>
    /// The color of emitted light, in energy-linear terms.
    /// </summary>
    Color3 Color { get; }

    /// <summary>
    /// Color temperature, in degrees Kelvin, representing the white point.
    /// </summary>
    float ColorTemperature { get; }

    /// <summary>
    /// Emits the light into the provided SoA builder.
    /// </summary>
    /// <param name="builder">Light SoA builder</param>
    void Emit(ref LightSoABuilder builder);
}