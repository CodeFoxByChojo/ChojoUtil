namespace ChojoUtil {
    public static class StringConverter {
        public static float StringToFloat(string text, int decimalPoints) {
            float result;
            text = text.Replace(",", ".");
            if (float.TryParse(text, out result)) {
                result = (float) System.Math.Round(result, decimalPoints);
                return result;
            }

            return 0;
        }
        
        public static float StringToFloat(string text) {
            float result;
            text = text.Replace(",", ".");
            if (float.TryParse(text, out result)) {
                result = (float) System.Math.Round(result, 2);
                return result;
            }

            return 0;
        }
        
        public static int StringToInt(string text, int remove) {
            int result;
            text = text.Replace("\u200B", "");
            int.TryParse(text, out result);
            return result;
        }


    }
}
