using Godot;

namespace YarnSpinnerGodot {
    public partial class YarnFile : Resource {
        [Export(PropertyHint.File, "*.yarn")]
        private string _yarnFile = string.Empty;
    }
}