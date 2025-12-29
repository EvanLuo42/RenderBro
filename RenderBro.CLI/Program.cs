using RenderBro.CLI;
using RenderBro.Rendering;

if (!Input.TryParse(args, out var settings, out var result))
{
    result.Invoke();
}

var renderer = new Renderer(settings);
renderer.Render();

return 0;
