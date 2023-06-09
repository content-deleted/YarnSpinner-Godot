namespace YarnSpinnerGodot {
    public class YarnLine {
        private string _text;
        private string _nodeName;
        private int _lineNumber;
        private string _fileName;
        private bool _implicit;
        private string[] _meta;

        public string Text => _text;
        public string NodeName => _nodeName;
        public int LineNumber => _lineNumber;
        public string FileName => _fileName;
        public bool Implicit => _implicit;
        public string[] Meta => _meta;

        public YarnLine(string text, string nodeName,
                int lineNumber, string fileName,
                bool @implicit, string[] meta) {
            this._text = text;
            this._nodeName = nodeName;
            this._lineNumber = lineNumber;
            this._fileName = fileName;
            this._implicit = @implicit;
            this._meta = meta;
        }
    }
}