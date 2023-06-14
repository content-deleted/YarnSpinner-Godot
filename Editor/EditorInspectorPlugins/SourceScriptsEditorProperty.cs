#if TOOLS
using Godot;
using Godot.Collections;

namespace Yarn.GodotYarn.Editor {
    using Node = Godot.Node;

    public partial class SourceScriptsEditorProperty : EditorProperty {
        public SourceScriptsEditorProperty() {

        }

        public override void _UpdateProperty() {
            string nullText = "<null>";

            GodotObject obj = this.GetEditedObject();

            if(obj == null) {
                // this._menuBar.Text = nullText;
                return;
            }

            var prop = obj.Get(this.GetEditedProperty()).AsGodotObjectArray<YarnScript>();

            if(prop == null) {
                // this._menuBar.Text = nullText;
                return;
            }

            for(int i = 0; i < this.GetChildCount(); ++i) {
                this.GetChild(i).Free();
            }

            for(int i = 0; i < prop.Length; ++i) {
                GD.Print(prop[i].ResourceName);

                LinkButton label = new LinkButton();
                label.Text = prop[i].ResourceName;
                label.Uri = prop[i].ResourcePath;

                this.AddChild(label);
            }
        }
    }
}

#endif