using AutoCAD2024Plugin.Commands;
using Autodesk.AutoCAD.Runtime;

// Registers this class with AutoCAD so its commands can be called with CommandMethod
[assembly: CommandClass(typeof(AutoCAD2024Plugin.AutoCadCommands))]

namespace AutoCAD2024Plugin
{
    public class AutoCadCommands
    {
        [CommandMethod("HELLOWORLD")]
        public static void HelloWorldCommand() => HelloWorld.Run();
    }
}