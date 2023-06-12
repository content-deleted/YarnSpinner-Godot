#if TOOLS
using Godot;

namespace Yarn.GodotYarn.Editor {
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
                "YarnScript",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "YarnScript.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnScript Icon.svg")
            );
            AddCustomType(
                "YarnProject",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "YarnProject.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnProject Icon.svg")
            );
            AddCustomType(
                "DialogueRunner",
                "Control",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "DialogueRunner.cs"),
                null
            );
            AddCustomType(
                "TextLineProvider",
                "Node",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "LineProviders/TextLineProvider.cs"),
                null
            );
            AddCustomType(
                "Declaration",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "Declaration.cs"),
                null
            );
            AddCustomType(
                "LanguageToSourceAsset",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "LanguageToSourceAsset.cs"),
                null
            );

            GD.Print("YarnSpinner-Godot plugin initialized");
        }

        public override void _ExitTree() {
            RemoveCustomType("TextLineProvider");
            RemoveCustomType("LanguageToSourceAsset");
            RemoveCustomType("Declaration");
            RemoveCustomType("DialogueRunner");
            RemoveCustomType("YarnProject");
            RemoveCustomType("YarnFile");

            if(_yarnImporterPlugin != null) {
                RemoveImportPlugin(_yarnImporterPlugin);
                _yarnImporterPlugin = null;
            }
        }
    }
}
#endif