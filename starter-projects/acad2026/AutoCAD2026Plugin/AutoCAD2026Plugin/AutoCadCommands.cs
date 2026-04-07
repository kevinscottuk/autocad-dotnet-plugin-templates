// Source template repository: https://github.com/kevinscottuk/autocad-dotnet-plugin-templates
using AutoCAD2026Plugin.Commands;
using Autodesk.AutoCAD.Runtime;

// Registers this class with AutoCAD so its commands can be called with CommandMethod
[assembly: CommandClass(typeof(AutoCAD2026Plugin.AutoCadCommands))]

namespace AutoCAD2026Plugin
{
    public class AutoCadCommands
    {
        [CommandMethod("HELLOWORLD")]
        public static void HelloWorldCommand() => HelloWorld.Run();
    }
}
