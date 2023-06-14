#if TOOLS
using Godot;

namespace Yarn.GodotYarn.Editor {
    public partial class LocalizationPopupEditorProperty : EditorProperty {
        private MenuButton _menuBar = new MenuButton();

        public LocalizationPopupEditorProperty() {


            AddChild(_menuBar);

            _menuBar.GetPopup().IdPressed += OnIdPressed;

            foreach(var c in Cultures.GetCultures()) {
                _menuBar.GetPopup().AddItem($"{c.DisplayName}:({c.Name})");
            }
        }

        private void OnIdPressed(long id) {
            int index = (int)id;

            string localeCode = _menuBar.GetPopup().GetItemText(index);
            _menuBar.Text = localeCode;

            localeCode = localeCode.Split(':')[1];
            localeCode = localeCode.Trim('(');
            localeCode = localeCode.Trim(')');

            Localization localization = new Localization(localeCode);

            this.GetEditedObject().Set(this.GetEditedProperty(), localization);
        }

        public override void _UpdateProperty() {
            // GD.Print("UpdateProperty");
            string nullText = "<null>";

            GodotObject obj = this.GetEditedObject();

            if(obj == null) {
                this._menuBar.Text = nullText;
                return;
            }

            var prop = obj.Get(this.GetEditedProperty()).AsGodotObject();

            if(prop == null) {
                this._menuBar.Text = nullText;
                return;
            }

            Localization localization = prop as Localization;

            if(localization == null) {
                this._menuBar.Text = nullText;
                return;
            }


            var culture = Cultures.GetCulture(localization.LocaleCode);
            _menuBar.Text = $"{culture.DisplayName}:({culture.Name})";
        }
    }
}
#endif