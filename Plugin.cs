#if TOOLS
using Godot;

namespace YarnSpinnerGodot {
    [Tool]
    public partial class Plugin : EditorPlugin {
        public const string ADDON_PATH = "res://addons/YarnSpinner-Godot/";


        public override void _EnterTree() {
            AddCustomType(
                "YarnFile",
                "Resource",
                ResourceLoader.Load<Script>(ADDON_PATH + "YarnFile.cs"),
                ResourceLoader.Load<Texture2D>(ADDON_PATH + "Icons/YarnScript Icon.svg")
            );

            GD.Print("YarnSpinner-Godot plugin initialized");
        }

        public override void _ExitTree() {
            RemoveCustomType("YarnFile");
        }
    }
}
#endif