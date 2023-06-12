using Godot;
using System;

namespace Yarn.GodotYarn {
    [Tool]
    public partial class LanguageToSourceAsset : Resource {
        [Export]
        public string LanguageID { set; get; }
        [Export(PropertyHint.File, "*.yarn")]
        public string StringFile { set; get; }
    }
}