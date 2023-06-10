using Godot;

namespace YarnSpinnerGodot {
    public partial class YarnScript : Resource {
        [Export(PropertyHint.Expression, "*.yarn")]
        private string _content = string.Empty;

        public YarnScript() {
            this._content = string.Empty;
        }

        public YarnScript(string content) {
            this._content = content;
        }
    }
}