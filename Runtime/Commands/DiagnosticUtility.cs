namespace Yarn.GodotYarn {
    internal static class DiagnosticUtility {
        public static string EnglishPluraliseNounCount(int count, string name, bool prefixCount = false) {
            string result;
            if (count == 1) {
                result = name;
            } else {
                result = name + "s";
            }
            if (prefixCount) {
                return count.ToString() + " " + result;
            } else {
                return result;
            }
        }

        public static string EnglishPluraliseWasVerb(int count) {
            if (count == 1) {
                return "was";
            } else {
                return "were";
            }
        }
    }
}