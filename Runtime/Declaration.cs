using Godot;
using System;

namespace Yarn.GodotYarn {
    public enum DeclarationType {
        STRING, BOOLEAN, NUMBER
    }

    public partial class Declaration : Resource {
        [Export] public string Name { get; set; }
        [Export] public DeclarationType Type { get; set; }
        [Export] public string DefaultValue { get; set; }
    }
}