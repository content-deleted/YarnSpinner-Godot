using Godot;
using System.Text.RegularExpressions;

namespace YarnSpinnerGodot {
    public class Rule {
        private Regex _regex;
        private string _enterState;
        private int _tokenType;
        private bool _isTextRule;
        private bool _delimitsText;

        public Rule(int type, string regex, string enterState, bool delimitsText) {
            this._tokenType = type;
            this._regex = new Regex(regex);
            this._enterState = enterState;
            this._delimitsText = delimitsText;
        }

        public override string ToString() {
            return $"[Rule : {(TokenType)_tokenType} - {_regex}]";
        }
    }
}