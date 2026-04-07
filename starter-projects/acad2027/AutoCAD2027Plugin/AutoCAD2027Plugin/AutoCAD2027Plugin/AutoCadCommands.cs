// Source template repository: https://github.com/kevinscottuk/autocad-dotnet-plugin-templates
using AutoCAD2027Plugin.Commands;
using Autodesk.AutoCAD.Runtime;

// Registers this class with AutoCAD so its commands can be called with CommandMethod
[assembly: CommandClass(typeof(AutoCAD2027Plugin.AutoCadCommands))]

namespace AutoCAD2027Plugin
{
    public class AutoCadCommands
    {
        [CommandMethod("HELLOWORLD")]
        public static void HelloWorldCommand() => HelloWorld.Run();
    }
}
