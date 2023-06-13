#if TOOLS
using Godot;

namespace Yarn.GodotYarn.Editor {
    using Node = Godot.Node;

    public partial class SourceScriptsEditorProperty : EditorProperty {
        public SourceScriptsEditorProperty() {
            this.Label = "Whi";
        }

        public override void _UpdateProperty() {
            Node parent = this.GetParent();

            var children = parent.GetChildren();

            foreach(var c in children) {
                GD.Print(c.GetType());
            }

            GD.Print("Update property");
        }
    }
}

#endif