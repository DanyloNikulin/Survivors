using System.Collections.Generic;
using UnityEngine;

public static class FigureUtills {

    private static List<Vector2> Circle;
    private static List<Vector2> Square;

    public static List<Vector2>  CalculateCircle(int scale) { 
        Circle = new List<Vector2>();
        for (float theta = 0; theta < 2 * Mathf.PI; theta += 2 * Mathf.PI / scale) {
            Circle.Add(new Vector2(1 * Mathf.Cos(theta), 1 * Mathf.Sin(theta)));
        }
        return Circle;
    }

    public static List<Vector2> CalculateSquare(int scale) {
        Square = new List<Vector2>();
        Square.Add (new Vector2(1,1));
        Square.Add(new Vector2(-1, -1));
        Square.Add(new Vector2(1, -1));
        Square.Add(new Vector2(-1, 1));

        for (float theta = 0; theta < (scale-4)/ 4; theta += 1/ ((scale-4)/4)) {
            Square.Add(new Vector2(1 - theta, 1));
            Square.Add(new Vector2(-1 , -1 + theta));
            Square.Add(new Vector2(1, -1 + theta));
            Square.Add(new Vector2(-1 + theta, 1));
        }
        return Square;
    }
    
}
