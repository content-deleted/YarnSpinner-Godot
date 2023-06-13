#if TOOLS
using Godot;
using Godot.Collections;

namespace Yarn.GodotYarn.Editor {
    public partial class YarnProjectEditorInspectorPlugin : EditorInspectorPlugin {
        YarnProject currentProject;

        private Dictionary<string, Callable> signalDict = new Dictionary<string, Callable>();

        public override bool _CanHandle(GodotObject targetObject) {
            bool canHandle = targetObject is YarnProject;

            YarnProject newProject = targetObject as YarnProject;

            if(canHandle) {
                if(currentProject != newProject) {
                    if(currentProject != null) {
                        DisconnectSignal("onSourceScriptsChanged");
                    }
                    currentProject = newProject;
                }

                currentProject = targetObject as YarnProject;

                ConnectSignal("onSourceScriptsChanged", "OnSourceScriptsChanged");
            }

            return canHandle;
        }

        private void ConnectSignal(string signalName, string methodName) {
            Callable c = new Callable(this, methodName);

            currentProject.Connect(signalName, c);

            signalDict.Add(signalName, c);
        }
        private void DisconnectSignal(string signalName) {
            currentProject.Disconnect(signalName, signalDict[signalName]);

            signalDict.Remove(signalName);
        }

        public override void _ParseBegin(GodotObject targetObject) {

        }

        private Label _sourceScriptsInfo;

        public override bool _ParseProperty(GodotObject targetObject, Variant.Type type, string name, PropertyHint hintType, string hintString, PropertyUsageFlags usageFlags, bool wide) {
            // GD.Print(name);

            GD.Print(name);

            switch(name) {
                case "SourceScripts":
                    _sourceScriptsInfo = new Label();
                    _sourceScriptsInfo.Text = "This Yarn Project has no content. Add Yarn Scripts to it.";
                    AddCustomControl(_sourceScriptsInfo);

                    return false;
            }


            return true;
        }

        private void OnSourceScriptsChanged(YarnScript[] scripts) {
            if(_sourceScriptsInfo == null || IsInstanceValid(_sourceScriptsInfo) == false) {
                return;
            }

            if(scripts.Length > 0) {
                _sourceScriptsInfo.Visible = false;
            }
            else {
                _sourceScriptsInfo.Visible = true;
            }
        }
    }
}
#endif