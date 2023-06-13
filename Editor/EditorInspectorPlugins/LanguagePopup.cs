#if TOOLS
using Godot;

namespace Yarn.GodotYarn.Editor {
    public partial class LanguagePopupEditorProperty : EditorProperty {
        private MenuButton _menuBar = new MenuButton();

        public LanguagePopupEditorProperty() {
            AddChild(_menuBar);

            foreach(var c in Cultures.GetCultures()) {
                _menuBar.GetPopup().AddItem($"{c.DisplayName}:({c.Name})");

            }

            _menuBar.Text = "Language";
        }

        public override void _UpdateProperty() {

        }
    }
}
#endif