using System.Collections.Generic;
using UnityEngine;

public static class FigureUtills {

    private static List<Vector2> Circle;
    private static List<Vector2> Square;
    private static int _resolution = 100;

	static FigureUtills() {
        CalculateCircle();
    }
    public static List<Vector2> CalculateCircleByStep(int amount) {
        List<Vector2> result = new List<Vector2>();
        int step = _resolution / amount;
        for (int i = 0; i * step < _resolution; i++) {
            result.Add(Circle[i*step]);
        }
        return result;
    }
    private static void  CalculateCircle() { 
        Circle = new List<Vector2>();
        for (float theta = 0; theta < 2 * Mathf.PI; theta += 2 * Mathf.PI / _resolution) {
            Circle.Add(new Vector2(1 * Mathf.Cos(theta), 1 * Mathf.Sin(theta)));
        }
    }

    public static List<Vector2> CalculateSquare(int scale) {
        Square = new List<Vector2>();
        Square.Add (new Vector2(1,1));
        Square.Add(new Vector2(-1, -1));
        Square.Add(new Vector2(1, -1));
        Square.Add(new Vector2(-1, 1));

        for (float theta = 0; theta < (scale-4)/ 4; theta += 0.5f/ ((scale-4)/4)) {
            Square.Add(new Vector2(1 - theta, 1));
            Square.Add(new Vector2(-1 , -1 + theta));
            Square.Add(new Vector2(1, -1 + theta));
            Square.Add(new Vector2(-1 + theta, 1));
        }
        return Square;
    }
    
}
