#if TOOLS
using Godot;
using Godot.Collections;

namespace Yarn.GodotYarn.Editor {
    public partial class YarnProjectEditorInspectorPlugin : EditorInspectorPlugin {
        public override bool _CanHandle(GodotObject targetObject) {

            return targetObject is YarnProject;
        }

        public override void _ParseBegin(GodotObject targetObject) {

        }

        public override bool _ParseProperty(GodotObject targetObject, Variant.Type type, string name, PropertyHint hintType, string hintString, PropertyUsageFlags usageFlags, bool wide) {
            // GD.Print(name);

            switch(name) {
                case "searchAssembliesForActions":
                case "SourceScripts":
                    // AddPropertyEditor(name, new SourceScriptsEditorProperty());
                    return false;
                case "baseLocalization":
                    AddPropertyEditor(name, new LocalizationPopupEditorProperty());
                    return true;
                default:
                    return true;
            }
        }
    }
}
#endif