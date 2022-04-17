using System;
using System.Collections.Generic;
using UnityEngine;

public static class FigureUtills {

    private static List<Vector2> Circle;

    public static List<Vector2>  CalculateCircle(int scale) { 
        Circle = new List<Vector2>();
        for (float theta = 0; theta < 2 * Mathf.PI; theta += 2 * Mathf.PI / scale) {
            Circle.Add(new Vector2(1 * Mathf.Cos(theta), 1 * Mathf.Sin(theta)));
        }
        return Circle;
    }
}
