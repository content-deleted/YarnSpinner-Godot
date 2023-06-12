using Godot;
using System;

namespace Yarn.GodotYarn {
    public partial class LanguageToSourceAsset : Resource {
        [Export]
        public string LanguageID { set; get; }
        [Export]
        public string StringFile { set; get; }
    }
}