using Godot;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Yarn.GodotYarn {
    // [GlobalClass]
    public partial class TextLineProvider : LineProviderBehaviour {
        /// <summary>
        /// Specifies the language code to use for text content
        /// for this <see cref="TextLineProvider"/>.
        /// </summary>
        [Language]
        public string textLanguageCode = System.Globalization.CultureInfo.CurrentCulture.Name;
        public override LocalizedLine GetLocalizedLine(Yarn.Line line) {
            // GD.Print(line.ID);
            // GD.Print(line.Substitutions);

            var text = YarnProject.GetLocalization(textLanguageCode).GetLocalizedString(line.ID);

            // GD.Print(text);

            return new LocalizedLine() {
                TextID = line.ID,
                RawText = text,
                Substitutions = line.Substitutions,
                // Metadata = YarnProject.lineMetadata.GetMetadata(line.ID),
            };
        }

        public override void PrepareForLines(IEnumerable<string> lineIDs) {
            // No-op; text lines are always available
        }

        public override bool LinesAvailable => true;
        public override string LocaleCode => textLanguageCode;
    }
}