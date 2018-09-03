using UnityEngine;

class ColorUtil {
    private const float TOLERANCE = 0.3f;
    private const float DEFAULT_ALPHA = 0;
    private static ColorUtil instance;

    private ColorUtil() {}

    public static ColorUtil getInstance() {
        if(instance == null) {
            instance = new ColorUtil();
        }

        return instance;
    }

    public Color calculateBlend(Color origin, Color target) {
        Color complement = getComplementaryColor(target);
        complement = complement * TOLERANCE;

        Color blend = origin - complement;

        return blend;
    }

    private Color getComplementaryColor(Color color) {
        float red = 1 - color.r;
        float green = 1 - color.g;
        float blue = 1 - color.b;

        return new Color(red, green, blue, DEFAULT_ALPHA);
    }
}