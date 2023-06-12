#if TOOLS
using Godot;
using Godot.Collections;

namespace Yarn.GodotYarn.Editor {
    [Tool]
    public partial class YarnImporterPlugin : EditorImportPlugin {
        private const string YARN_TRACKER_PATH = Plugin.ADDON_PATH + ".tracked_yarn_files";

        public override string _GetImporterName() => "com.YarnSpinnerGodot.YarnFile";
        public override string _GetVisibleName() => "Yarn Files";
        public override float _GetPriority() => 1.0f;
        public override int _GetImportOrder() => 0;
        public override string[] _GetRecognizedExtensions() => new string[] { "yarn" };
        public override string _GetSaveExtension() => "tres";
        public override string _GetResourceType() => "Resource";
        public override int _GetPresetCount() => 1;
        public override string _GetPresetName(int presetIndex) => "Default";
        public override Array<Dictionary> _GetImportOptions(string path, int presetIndex) {
            return new Array<Dictionary>();
        }

        public override Error _Import(string sourceFile, string savePath, Dictionary options, Array<string> platformVariants, Array<string> genFiles) {
            GD.Print("Importing -> ", sourceFile);

            // string content = string.Empty;

            // using(FileAccess access = FileAccess.Open(sourceFile, FileAccess.ModeFlags.Read)) {
            //     content = access.GetAsText();
            // }

            // After we're done caching the tracked files, we now import the yarn file

            string saveFilePath = $"{savePath}.{_GetSaveExtension()}";

            YarnScript yarnFile = new YarnScript();
            yarnFile.ResourcePath = sourceFile;
            yarnFile.ResourceName = sourceFile.GetFile();

            return ResourceSaver.Save(yarnFile, saveFilePath);
        }
    }
}
#endif