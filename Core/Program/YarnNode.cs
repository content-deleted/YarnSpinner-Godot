using Godot;
using Godot.Collections;

namespace YarnSpinnerGodot {
    public partial class YarnNode : GodotObject, System.IEquatable<YarnNode> {
        private string _nodeName;
        private Array _instructions = new Array();

        private Dictionary _labels = new Dictionary();
        private Array _tags = new Array();
        private string _sourceID;

        public string NodeName => _nodeName;
        public Array Instructions => _instructions;
        public Dictionary Labels => _labels;
        public Array Tags => _tags;
        public string SourceID => _sourceID;

        public YarnNode(YarnNode other = null) {
            if(other != null && other.GetScript().AsGodotObject() == this.GetScript().AsGodotObject()) {
                _nodeName = other._nodeName;
                _instructions = other._instructions;
                foreach(var key in other._labels.Keys) {
                    _labels[key] = other._labels[key];
                }
                _tags += other._tags;
                _sourceID = other._sourceID;
            }
        }

        public bool Equals(YarnNode other) {
            if(other.GetScript().AsGodotObject() != this.GetScript().AsGodotObject()) {
                return false;
            }
            if(other._nodeName != this._nodeName) {
                return false;
            }
            if(other._instructions != this._instructions) {
                return false;
            }
            if(other._labels != this._labels) {
                return false;
            }
            if(other._sourceID != this._sourceID) {
                return false;
            }
            return true;
        }

        public override string ToString() {
            return $"{_nodeName}:{_sourceID}";
        }
    }
}