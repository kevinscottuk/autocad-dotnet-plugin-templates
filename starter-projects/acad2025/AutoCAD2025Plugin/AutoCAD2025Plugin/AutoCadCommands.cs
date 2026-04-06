using AutoCAD2025Plugin.Commands;
using Autodesk.AutoCAD.Runtime;

// Registers this class with AutoCAD so its commands can be called with CommandMethod
[assembly: CommandClass(typeof(AutoCAD2025Plugin.AutoCadCommands))]

namespace AutoCAD2025Plugin
{
    public class AutoCadCommands
    {
        [CommandMethod("HELLOWORLD")]
        public static void HelloWorldCommand() => HelloWorld.Run();
    }
}