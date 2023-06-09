#if TOOLS
using Godot;

namespace YarnSpinnerGodot {
    [Tool]
    public partial class Plugin : EditorPlugin {

        public override void _EnterTree() {
            GD.Print("YarnSpinner-Godot plugin initialized");
        }

        public override void _ExitTree() {

        }
    }
}
#endif