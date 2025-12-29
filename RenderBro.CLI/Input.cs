using System.CommandLine;
using System.CommandLine.Parsing;
using RenderBro.Core;

namespace RenderBro.CLI;

public sealed class Input
{
    private static readonly Option<FileInfo> SceneOption = new("--scene")
    {
        Description = "Path to scene file. (Supported formats: pbrt-v4 | OpenUSD)",
        Required = true,
        Arity = ArgumentArity.ExactlyOne
    };
    private static readonly RootCommand RootCommand = new("RenderBro CLI");

    static Input()
    {
        RootCommand.Options.Add(SceneOption);
    }
    
    public static bool TryParse(
        string[] args, 
        out RenderSettings settings, 
        out ParseResult result)
    {
        var parseResult = RootCommand.Parse(args);
        result = parseResult;
        if (parseResult.Errors.Count > 0)
        {
            settings = null!;
            return false;
        }
        
        settings = new RenderSettings();
        MapSettings(parseResult, settings);
        return true;
    }

    private static void MapSettings(ParseResult result, in RenderSettings settings)
    {
        var scene = result.GetValue(SceneOption)!;
    }
}