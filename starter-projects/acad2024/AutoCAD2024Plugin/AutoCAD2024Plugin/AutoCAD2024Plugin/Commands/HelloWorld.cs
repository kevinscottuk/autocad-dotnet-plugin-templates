// Source template repository: https://github.com/kevinscottuk/autocad-dotnet-plugin-templates
using Application = Autodesk.AutoCAD.ApplicationServices.Application;

namespace AutoCAD2024Plugin.Commands
{
    internal static class HelloWorld
    {
        internal static void Run()
        {
            var doc = Application.DocumentManager.MdiActiveDocument;
            doc?.Editor.WriteMessage(
                "\n[HELLOWORLD] Hello from your AutoCAD plugin\n");
        }
    }
}
