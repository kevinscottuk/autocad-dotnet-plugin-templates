using Autodesk.AutoCAD.Runtime;
using Application = Autodesk.AutoCAD.ApplicationServices.Core.Application;

// This attribute specifies the plugin's entry point class.
// It improves load performance by avoiding type scanning.
[assembly: ExtensionApplication(typeof(AutoCAD2024Plugin.AutoCadPlugin))]

namespace AutoCAD2024Plugin
{
    public class AutoCadPlugin : IExtensionApplication
    {
        public void Initialize()
        {
            var msg = $"\n[{GetType().FullName}] Plugin loaded.\n";
            Application.DocumentManager.MdiActiveDocument.Editor.WriteMessage(msg);
        }

        public void Terminate()
        {
            // Add clean-up logic here if your plugin sets up event handlers or shared state.
        }
    }
}