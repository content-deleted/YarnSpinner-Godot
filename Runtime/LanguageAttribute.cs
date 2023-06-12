using System;

namespace Yarn.GodotYarn {
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class LanguageAttribute : Attribute {
        // No data or methods on this attribute; it's purely a marker.
    }
}