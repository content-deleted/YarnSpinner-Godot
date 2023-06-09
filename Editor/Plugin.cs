#if TOOLS
using Godot;

namespace YarnSpinnerGodot {
    [Tool]
    public partial class Plugin : EditorPlugin {
        public const string ADDON_PATH = "res://addons/YarnSpinner-Godot/";
        public const string RUNTIME_PATH = ADDON_PATH + "Runtime/";
        public const string EDITOR_PATH = ADDON_PATH + "Editor/";


        public override void _EnterTree() {
            AddCustomType(
                "YarnFile",
                "Resource",
                ResourceLoader.Load<Script>(ADDON_PATH + "YarnFile.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnScript Icon.svg")
            );
            AddCustomType(
                "YarnProgram",
                "Resource",
                ResourceLoader.Load<Script>(RUNTIME_PATH + "Core/Program/YarnProgram.cs"),
                ResourceLoader.Load<Texture2D>(EDITOR_PATH + "Icons/YarnProject Icon.svg")
            );

            GD.Print("YarnSpinner-Godot plugin initialized");
        }

        public override void _ExitTree() {
            RemoveCustomType("YarnFile");
            RemoveCustomType("YarnProgram");
        }
    }
}
#endif