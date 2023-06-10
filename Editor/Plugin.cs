#if TOOLS
using Godot;

namespace YarnSpinnerGodot.Editor {
    [Tool]
    public partial class Plugin : EditorPlugin {
        public const string ADDON_PATH = "res://addons/YarnSpinner-Godot/";
        public const string RUNTIME_PATH = ADDON_PATH + "Runtime/";
        public const string EDITOR_PATH = ADDON_PATH + "Editor/";

        private YarnImporterPlugin _yarnImporterPlugin;


        public override void _EnterTree() {
            _yarnImporterPlugin = new YarnImporterPlugin();
            AddImportPlugin(_yarnImporterPlugin);


            AddCustomType(
                "YarnFile",
                "Resource",
                ResourceLoader.Load<Script>(ADDON_PATH + "YarnFile.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnScript Icon.svg")
            );
            AddCustomType(
                "YarnProject",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "YarnProject.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnProject Icon.svg")
            );

            GD.Print("YarnSpinner-Godot plugin initialized");
        }

        public override void _ExitTree() {
            RemoveCustomType("YarnFile");
            RemoveCustomType("YarnProject");

            if(_yarnImporterPlugin != null) {
                RemoveImportPlugin(_yarnImporterPlugin);
                _yarnImporterPlugin = null;
            }
        }
    }
}
#endif